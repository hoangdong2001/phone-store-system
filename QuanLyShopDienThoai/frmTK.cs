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
    public partial class frmTK : Form
    {
        public frmTK()
        {
            InitializeComponent();
        }
        public static string isMainButton = "";
        public int month = 0;
        public int year = 0;

        //Hiển thị giao diện dữ liệu tương ứng với sự kiện click ở giao diện chính (frmMain)
        private void frmTK_Load(object sender, EventArgs e)
        {
            if (isMainButton == "themtk")
            {
                btnUpdateTK.Visible = false;
                ThongKeDAO.Instance.InsertTK(DateTime.Now);
                txtNgayTK.Text = DateTime.Today.ToString("dd/MM/yyyy hh:mm:ss");
                month = DateTime.Today.Month;
                year = DateTime.Today.Year;
                txtMaTK.Text = DataProvider.Instance.ExcuteScalar("SELECT Max(ID) FROM ThongKe");
                txtMaTK.Enabled = false;
                txtNgayTK.Enabled = false;
            }
            if (isMainButton == "suatk")
            {
                btnAddTK.Visible = false;
                month = int.Parse(DataProvider.Instance.ExcuteScalar("SELECT MONTH(NgayTK) FROM ThongKe WHERE ID =" + int.Parse(frmMain.MaTK)));
                year = int.Parse(DataProvider.Instance.ExcuteScalar("SELECT YEAR(NgayTK) FROM ThongKe WHERE ID =" + int.Parse(frmMain.MaTK)));
                try
                {
                    DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM ThongKe WHERE ID = " + int.Parse(frmMain.MaTK));
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txtMaTK.Text = dr["ID"].ToString();
                            txtNgayTK.Text = dr["NgayTK"].ToString();
                            txtThu.Text = dr["Thu"].ToString();
                            txtChi.Text = dr["Chi"].ToString();
                            txtDoanhThu.Text = dr["DoanhThu"].ToString();
                        }
                        txtMaTK.Enabled = false;
                        txtNgayTK.Enabled = false;
                    }
                }
                catch (Exception) { }
            }
            if (isMainButton == "xemtk")
            {
                btnAddTK.Visible = false;
                btnKtraTK.Visible = false;
                btnUpdateTK.Visible = false;

                try
                {
                    DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM ThongKe WHERE ID = " + int.Parse(frmMain.MaTK));
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txtMaTK.Text = dr["ID"].ToString();
                            txtNgayTK.Text = dr["NgayTK"].ToString();
                            txtThu.Text = dr["Thu"].ToString();
                            txtChi.Text = dr["Chi"].ToString();
                            txtDoanhThu.Text = dr["DoanhThu"].ToString();
                        }
                        txtMaTK.Enabled = false;
                        txtNgayTK.Enabled = false;
                        txtThu.Enabled = false;
                        txtChi.Enabled = false;
                        txtDoanhThu.Enabled = false;
                    }
                }
                catch (Exception) { }
            }
        }

        //Trả về dữ liệu thu, chi, doanh thu của phiếu thống kê theo tháng kề trước tháng hiện tại
        private void btnKtraTK_Click(object sender, EventArgs e)
        {
            string thu = "";
            string chi = "";
            float doanhthu = 0;
            try
            {
                int id = int.Parse(txtMaTK.Text);
                if (month == 1)
                {
                    year = year - 1;
                    month = 12;
                    thu = DataProvider.Instance.ExcuteScalar("SELECT SUM(TongTien) FROM HoaDon WHERE Year(NgayLap) =" + year.ToString() + "AND Month(NgayLap) = " + month.ToString());
                    chi = DataProvider.Instance.ExcuteScalar("SELECT SUM(ChiPhi) FROM NhapHang WHERE Year(NgayNH) =" + year.ToString() + "AND Month(NgayNH) = " + month.ToString());
                    if (thu == "" && chi != "")
                    {
                        thu = "0";
                        doanhthu = 0 - float.Parse(chi);
                        ThongKeDAO.Instance.UpdateTK(id, 0, float.Parse(chi), doanhthu);
                    }
                    else if (thu != "" && chi == "")
                    {
                        chi = "0";
                        doanhthu = float.Parse(thu);
                        ThongKeDAO.Instance.UpdateTK(id, float.Parse(thu), 0, doanhthu);
                    }
                    else
                    {
                        doanhthu = float.Parse(thu) - float.Parse(chi);
                        ThongKeDAO.Instance.UpdateTK(id, float.Parse(thu), float.Parse(chi), doanhthu);
                    }
                }
                else
                {
                    month = month - 1;
                    thu = DataProvider.Instance.ExcuteScalar("SELECT SUM(TongTien) FROM HoaDon WHERE Year(NgayLap) =" + year.ToString() + "AND Month(NgayLap) = " + month.ToString());
                    chi = DataProvider.Instance.ExcuteScalar("SELECT SUM(ChiPhi) FROM NhapHang WHERE Year(NgayNH) =" + year.ToString() + "AND Month(NgayNH) = " + month.ToString());
                    if (thu == "" && chi != "")
                    {
                        thu = "0";
                        doanhthu = 0 - float.Parse(chi);
                        ThongKeDAO.Instance.UpdateTK(id, 0, float.Parse(chi), doanhthu);
                    }
                    else if (thu != "" && chi == "")
                    {
                        chi = "0";
                        doanhthu = float.Parse(thu);
                        ThongKeDAO.Instance.UpdateTK(id, float.Parse(thu), 0, doanhthu);
                    }
                    else
                    {
                        doanhthu = float.Parse(thu) - float.Parse(chi);
                        ThongKeDAO.Instance.UpdateTK(id, float.Parse(thu), float.Parse(chi), doanhthu);
                    }
                }
                txtThu.Text = thu;
                txtChi.Text = chi;
                txtDoanhThu.Text = doanhthu.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu để thống kê!");
                this.Hide();
            }
        }

        //Cập nhật phiếu thống kê
        private void btnUpdateTK_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtMaTK.Text);
                float thu = float.Parse(txtThu.Text);
                float chi = float.Parse(txtChi.Text);
                float doanhthu = thu - chi;
                txtDoanhThu.Text = doanhthu.ToString();
                ThongKeDAO.Instance.UpdateTK(id, thu, chi, doanhthu);
                MessageBox.Show("Đã cập nhật");
            }
            catch (Exception) { }
            this.Hide();
        }

        //Thêm phiếu thống kê
        private void btnAddTK_Click(object sender, EventArgs e)
        {
            if (txtThu.Text == "" && txtChi.Text == "" && txtDoanhThu.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra thông kế!");
            }
            else
            {
                this.Hide();
            }
        }
    }
}
