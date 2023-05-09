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
    public partial class frmNH : Form
    {
        public frmNH()
        {
            InitializeComponent();
        }
        public static string isMainButton = "";

        //Hiển thị giao diện dữ liệu tương ứng với sự kiện Click tương ứng ở giao diện chính (frmMain)
        private void frmNH_Load(object sender, EventArgs e)
        {
            if (isMainButton == "themnh")
            {
                btnUpdateNH.Visible = false;
                txtMaNH.Enabled = false;
                txtNgayNH.Text = DateTime.Today.ToString("dd/MM/yyyy");
                txtNgayNH.Enabled = false;
            }
            if (isMainButton == "suanh")
            {
                txtMaNH.Text = frmMain.MaNH;
                txtMaNH.Enabled = false;
                btnTaoNH.Enabled = false;
                DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT NgayNH FROM NhapHang WHERE MaNH = " + int.Parse(frmMain.MaNH));
                foreach (DataRow dr in dt.Rows)
                {
                    txtNgayNH.Text = dr["NgayNH"].ToString();
                }
                txtNgayNH.Enabled = false;
                btnAddNH.Visible = false;
                dgvChiTietNH.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH,TenHH,DonGia,SL,ThanhTien FROM ChiTietNH WHERE MaNH = "+ int.Parse(frmMain.MaNH));
            }
            if (isMainButton == "xemnh")
            {
                pnEditNH.Visible = false;
                btnTaoNH.Visible = false;
                DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM NhapHang WHERE MaNH = " + frmMain.MaNH);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtMaNH.Text = dr["MaNH"].ToString();
                        txtNgayNH.Text = dr["NgayNH"].ToString();
                    }
                }
                txtMaNH.Enabled = false;
                txtNgayNH.Enabled = false;
                dgvChiTietNH.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH,TenHH,DonGia,SL,ThanhTien FROM ChiTietNH WHERE MaNH = " + int.Parse(frmMain.MaNH));
            }
        }

        //Kiểm tra và trả về dữ liệu của hàng hóa
        private void btnKtraNH_Click(object sender, EventArgs e)
        {
            if (txtMaHH.Text == "")
            {
                MessageBox.Show("Nhập mã hàng hóa!");
                txtMaHH.Focus();
            }
            else
            {
                string mahh = txtMaHH.Text;
                DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM HangHoa WHERE MaHH = " + mahh);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtTenHH.Text = dr["TenHH"].ToString();
                        txtXuatxu.Text = dr["XuatXu"].ToString();
                    }
                }
            }
        }

        //Thêm đơn nhập hàng
        private void btnAddNH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoàn tất nhập hàng!");
            try
            {
                int manh = int.Parse(txtMaNH.Text);
                string tongtien = DataProvider.Instance.ExcuteScalar("SELECT SUM(ThanhTien) FROM ChiTietNH WHERE MaNH = " + manh);
                DataProvider.Instance.ExcuteNonQuery("UPDATE NhapHang SET ChiPhi = " + tongtien + " WHERE MaNH = " + manh);
            }
            catch (Exception) { }
            this.Hide();
        }

        //Cập nhật đơn nhập hàng
        private void btnUpdateNH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoàn tất!");
            try
            {
                int manh = int.Parse(txtMaNH.Text);
                string tongtien = DataProvider.Instance.ExcuteScalar("SELECT SUM(ThanhTien) FROM ChiTietNH WHERE MaNH = " + manh);
                DataProvider.Instance.ExcuteNonQuery("UPDATE NhapHang SET ChiPhi = " + tongtien + " WHERE MaNH = " + manh);
            }
            catch (Exception) 
            {
                int manh = int.Parse(txtMaNH.Text);
                string tongtien = "";
                DataProvider.Instance.ExcuteNonQuery("UPDATE NhapHang SET ChiPhi = NULL  WHERE MaNH = " + manh);
                dgvChiTietNH.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH,TenHH,DonGia,SL,ThanhTien FROM ChiTietNH WHERE MaNH = " + manh);
            }
            this.Hide();
        }

        //Thêm hàng hóa vào đơn nhập hàng
        private void btnThemHH_Click(object sender, EventArgs e)
        {
            if (txtMaNH.Text == "")
            {
                MessageBox.Show("Hãy tạo phiếu nhập hàng!");
            }    
            else if (txtMaHH.Text == "" || txtTenHH.Text == "" || txtDongia.Text == "" || txtSL.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin cần thiết!");
            }
            else
            {
                int manh = int.Parse(txtMaNH.Text);
                string mahh = txtMaHH.Text;
                string tenhh = txtTenHH.Text;
                string xuatxu = txtXuatxu.Text;
                float giatien = float.Parse(txtDongia.Text);
                int sl = int.Parse(txtSL.Text);
                float thanhtien = giatien * sl;
                try
                {
                    if (ChiTietNHDAO.Instance.InsertCTNH(manh, mahh, tenhh, xuatxu, giatien, sl, thanhtien))
                    {
                        string query = "UPDATE HangHoa SET SL +=" + sl + " WHERE MaHH = '" + mahh + "'";
                        DataProvider.Instance.ExcuteNonQuery(query);
                        dgvChiTietNH.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH,TenHH,DonGia,SL,ThanhTien FROM ChiTietNH WHERE MaNH = " + int.Parse(txtMaNH.Text));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiểm tra lại thông tin nhập hàng!");
                }
            }
        }

        //Xóa hàng hóa khỏi đơn nhập hàng
        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            if (MaHH == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                string id = MaHH;
                ChiTietNHDAO.Instance.DeleteCTNH(id);
                dgvChiTietNH.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH,TenHH,DonGia,SL,ThanhTien FROM ChiTietNH");
            }
        }

        //Tạo đơn nhập hàng 
        private void btnTaoNH_Click(object sender, EventArgs e)
        {
            int manh = 0;
            if (DataProvider.Instance.ExcuteScalar("SELECT Max(MaNH) FROM NhapHang") == "")
            {
                txtMaNH.Text = "1";
                manh = int.Parse(txtMaNH.Text);
                NhapHangDAO.Instance.InsertNH(manh, DateTime.Today);
            }
            else
            {
                string tmp = DataProvider.Instance.ExcuteScalar("SELECT Max(MaNH) FROM NhapHang");
                manh = int.Parse(tmp) + 1;
                txtMaNH.Text = manh.ToString();
                txtNgayNH.Text = DateTime.Today.ToString("dd/MM/yyyy");
                NhapHangDAO.Instance.InsertNH(manh, DateTime.Today);
            }    
        }

        //Trả về mã hàng hóa của hàng hóa được chọn trong chi tiết đơn nhập hàng
        public static string MaHH = "";
        private void dgvChiTietNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MaHH = dgvChiTietNH.Rows[e.RowIndex].Cells["clMaHH"].FormattedValue.ToString();
            }
            catch (Exception) { }
        }
    }
}
