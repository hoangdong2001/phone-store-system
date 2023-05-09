using QuanLyShopDienThoai.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopDienThoai
{
    public partial class frmHD : Form
    {
        public frmHD()
        {
            InitializeComponent();
        }
        public static string isMainButton = "";

        //Hiển thị giao diện dữ liệu tương ứng với sự kiện click ở giao diện chính (frmMain)
        private void frmHD_Load(object sender, EventArgs e)
        {
            if (isMainButton == "themhd")
            {
                try
                {
                    btnUpdateHD.Visible = false;
                    HoaDonDAO.Instance.InsertHD(DateTime.Now);
                    txtNgayHD.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    txtSoHD.Text = DataProvider.Instance.ExcuteScalar("SELECT Max(SoHD) FROM HoaDon");
                    txtSoHD.Enabled = false;
                    txtNgayHD.Enabled = false;
                    txtMaHH.Focus();
                }
                catch (Exception) { }
            }
            if (isMainButton == "suahd")
            {
                try
                {
                    btnThanhToan.Visible = false;
                    txtSoHD.Text = frmMain.SoHD;
                    dgvDonHang.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH, TenHH, DonGia, SL, ThanhTien FROM DonHang WHERE SoHD = " + frmMain.SoHD);
                    DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT NgayLap, TongTien FROM HoaDon WHERE SoHD = " + int.Parse(frmMain.SoHD));
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtNgayHD.Text = dr["NgayLap"].ToString();
                        tvTongTien.Text = dr["TongTien"].ToString();
                    }
                    txtSoHD.Enabled = false;
                    txtNgayHD.Enabled = false;
                }
                catch (Exception) { }
            }
            if (isMainButton == "xemhd")
            {
                pnEditHD.Visible = false;
                try
                {
                    DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM HoaDon WHERE SoHD = " + frmMain.SoHD);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txtSoHD.Text = dr["SoHD"].ToString();
                            txtNgayHD.Text = dr["NgayLap"].ToString();
                            tvTongTien.Text = dr["TongTien"].ToString() + " vnđ";
                        }
                    }
                    txtSoHD.Enabled = false;
                    txtNgayHD.Enabled = false;
                    dgvDonHang.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH, TenHH, DonGia, SL, ThanhTien FROM DonHang WHERE SoHD = " + int.Parse(frmMain.SoHD));
                }
                catch (Exception) { }
            }
        }

        //Thêm hàng hóa cho hóa đơn
        private void btnThemHH_Click(object sender, EventArgs e)
        {
            if (txtMaHH.Text == "" || txtSL.Text == "")
            {
                MessageBox.Show("Nhập thông tin cho sản phẩm!");
            }
            else
            {
                try
                {
                    int sohd = int.Parse(txtSoHD.Text);
                    string mahh = txtMaHH.Text;
                    string tenhh = tvTenHH.Text;
                    float gia = float.Parse(tvDonGia.Text);
                    int sl = int.Parse(txtSL.Text);
                    float thanhtien = gia * sl;

                    if (DonHangDAO.Instance.InsertDH(sohd, mahh, tenhh, gia, sl, thanhtien))
                    {
                        string query = "UPDATE HangHoa SET SL -=" + sl + " WHERE MaHH = '" + mahh + "'";
                        DataProvider.Instance.ExcuteNonQuery(query);
                        dgvDonHang.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH, TenHH, DonGia, SL, ThanhTien FROM DonHang WHERE SoHD = " + int.Parse(txtSoHD.Text));
                    }
                }
                catch (Exception) { }             
            }
        }

        //Xóa hàng hóa khỏi hóa đơn
        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            if (MaHH == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                try
                {
                    string id = MaHH;
                    DonHangDAO.Instance.DeleteDH(id);
                    dgvDonHang.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH,TenHH,DonGia,SL,ThanhTien FROM DonHang WHERE SoHD = " + int.Parse(txtSoHD.Text));
                }
                catch (Exception) { }            
            }
        }

        private void txtMaHH_Leave(object sender, EventArgs e)
        {
            string mahh = txtMaHH.Text;
            DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM HangHoa WHERE MaHH = '" + mahh + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    tvTenHH.Text = dr["TenHH"].ToString();
                    tvDonGia.Text = dr["GiaBan"].ToString();
                }
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            float gia = float.Parse(tvDonGia.Text);
            int sl = 0;
            if (txtSL.Text != "")
            {
                sl = int.Parse(txtSL.Text);
            }
            float thanhtien = gia * sl;
            tvThanhTien.Text = thanhtien.ToString();
        }

        //Thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int sohd = int.Parse(txtSoHD.Text);
                string tongtien = DataProvider.Instance.ExcuteScalar("SELECT SUM(ThanhTien) FROM DonHang WHERE SoHD = " + sohd);
                DataProvider.Instance.ExcuteNonQuery("UPDATE HoaDon SET TongTien = " + tongtien + " WHERE SoHD = " + sohd);
                tvTongTien.Text = tongtien + " vnđ";
            }
            catch (Exception) { }
        }

        //Cập nhật hóa đơn
        private void btnUpdateHD_Click(object sender, EventArgs e)
        {
            try
            {
                int sohd = int.Parse(txtSoHD.Text);
                string tongtien = DataProvider.Instance.ExcuteScalar("SELECT SUM(ThanhTien) FROM DonHang WHERE SoHD = " + sohd);
                DataProvider.Instance.ExcuteNonQuery("UPDATE HoaDon SET TongTien = " + tongtien + " WHERE SoHD = " + sohd);
                tvTongTien.Text = tongtien + " vnđ";
                MessageBox.Show("Đã cập nhật!");
            }
            catch (Exception) 
            {
                int sohd = int.Parse(txtSoHD.Text);
                tvTongTien.Text = "";
                MessageBox.Show("Đã cập nhật!");
                DataProvider.Instance.ExcuteNonQuery("UPDATE HoaDon SET TongTien = NULL WHERE SoHD = " + sohd);
            }
            this.Hide();
        }

        public string MaHH = "";
        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MaHH = dgvDonHang.Rows[e.RowIndex].Cells["clMaHH"].FormattedValue.ToString();
            }
            catch (Exception) { }
        }
    }
}
