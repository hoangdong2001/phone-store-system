using QuanLyShopDienThoai.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopDienThoai
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /* Phân quyền truy cập các chức năng cho user dựa trên tài khoản được cung cấp 
         * Nếu là "admin" -> tất cả button chức năng đều được mở
         * Nếu là "nvkho" -> Khóa các chức năng ngoại trừ "Nhập hàng" và "Hàng hóa"
         * Nếu là "nvbanhang" -> khóa các chức năng ngoại trừ "Hóa Đơn"
         */
        public static string permission;
        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLShopDienThoaiDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLShopDienThoaiDataSet.NhanVien);
            if (permission == "admin")
            {
                LoadNV();
            }
            if (permission == "nvkho")
            {
                LoadNH();
                btnNV.Enabled = false;
                btnTK.Enabled = false;
                btnHD.Enabled = false;
                pnNV.Visible = false;
                pnNH.Visible = true;
            }
            else if (permission == "nvbanhang")
            {
                LoadHD();
                btnNV.Enabled = false;
                btnNH.Enabled = false;
                btnTK.Enabled = false;
                btnHH.Enabled = false;
                pnNV.Visible = false;
                pnHD.Visible = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Đổi tài khoản
        private void btnChangeAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.Show();
        }

        //Hiển thị dữ liệu của trang "Nhân viên"
        public void LoadNV()
        {
            string query = "SELECT MaNV, Hoten, Gioi, ChucVu FROM NhanVien";
            try
            {
                dgvNV.DataSource = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dư liệu truy cập");
            }
        }
        
        //Hiển thị giao diện của trang"Nhập hàng"
        public void LoadNH()
        {
            string query = "SELECT MaNH, NgayNH, ChiPhi FROM NhapHang";
            try
            {
                dgvNH.DataSource = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dư liệu truy cập");
            }
        }

        //Hiển thị giao diện của trang"Thống kê"
        public void LoadTK()
        {
            string query = "SELECT ID, NgayTK, DoanhThu FROM ThongKe";
            try
            {
                dgvTK.DataSource = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dư liệu truy cập");
            }
        }

        //Hiển thị giao diện của trang"Hàng hóa"
        public void LoadHH()
        {
            string query = "SELECT MaHH, tenHH, SL FROM HangHoa";
            try
            {
                dgvHH.DataSource = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dư liệu truy cập");
            }
        }

        //Hiển thị giao diện của trang"Hóa đơn"
        public void LoadHD()
        {
            string query = "SELECT SoHD, NgayLap, TongTien FROM HoaDon";
            try
            {
                dgvHD.DataSource = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dư liệu truy cập");
            }
        }

        //Sự kiện click của các Button chức năng chính
        private void btnNV_Click(object sender, EventArgs e)
        {
            LoadNV();
            pnNV.Show();
            pnNH.Hide();
            pnTK.Hide();
            pnHH.Hide();
            pnHD.Hide();
        }

        private void btnNH_Click(object sender, EventArgs e)
        {
            LoadNH();
            pnNV.Hide();
            pnNH.Show();
            pnTK.Hide();
            pnHH.Hide();
            pnHD.Hide();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            LoadTK();
            pnNV.Hide();
            pnNH.Hide();
            pnTK.Show();
            pnHH.Hide();
            pnHD.Hide();
        }

        private void btnHH_Click(object sender, EventArgs e)
        {
            LoadHH();
            pnNV.Hide();
            pnNH.Hide();
            pnTK.Hide();
            pnHH.Show();
            pnHD.Hide();
        }
        private void btnHD_Click(object sender, EventArgs e)
        {
            LoadHD();
            pnNV.Hide();
            pnNH.Hide();
            pnTK.Hide();
            pnHH.Hide();
            pnHD.Show();
        }
        //-------------------------------------------------------------

        public string isMainButton = "";
        
        //Thêm, sửa, xem, xóa nhân viên
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmNV.isMainButton = "themnv";
            frmNV frmNhanvien = new frmNV();
            frmNhanvien.Show();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (MaNV == "")
            {
                MessageBox.Show("Nhân viên không tồn tại!");
            }
            else
            {
                frmNV.isMainButton = "suanv";
                frmNV frmNhanvien = new frmNV();
                frmNhanvien.Show();
            }
        }

        private void btnXemNV_Click(object sender, EventArgs e)
        {
            if (MaNV == "")
            {
                MessageBox.Show("Nhân viên không tồn tại!");
            }
            else
            {
                frmNV.isMainButton = "xemnv";
                frmNV frmNhanvien = new frmNV();
                frmNhanvien.Show();
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MaNV == "")
            {
                MessageBox.Show("Nhân viên không tồn tại");
            }
            else
            {
                string id = MaNV;
                DialogResult notify = MessageBox.Show("Bạn có muốn xóa nhân viên này?", "", MessageBoxButtons.YesNo);
                if (notify == DialogResult.Yes)
                {
                    NhanVienDAO.Instance.DeleteNV(id);
                }
                else
                {
                    return;
                }
                LoadNV();
            }

        }

        //Thêm, sửa, xem, xóa nhập hàng
        private void btnThemNH_Click(object sender, EventArgs e)
        {
            frmNH.isMainButton = "themnh";
            frmNH frmNhaphang = new frmNH();
            frmNhaphang.Show();
        }

        private void btnSuaNH_Click(object sender, EventArgs e)
        {
            if (MaNH == "")
            {
                MessageBox.Show("Đơn nhập hàng không tồn tại!");
            }
            else
            {
                frmNH.isMainButton = "suanh";
                frmNH frmNhaphang = new frmNH();
                frmNhaphang.Show();
            }

        }

        private void btnXemNH_Click(object sender, EventArgs e)
        {
            if (MaNH == "")
            {
                MessageBox.Show("Đơn nhập hàng không tồn tại!");
            }
            else
            {
                frmNH.isMainButton = "xemnh";
                frmNH frmNhaphang = new frmNH();
                frmNhaphang.Show();
            }
        }

        private void btnXoaNH_Click(object sender, EventArgs e)
        {
            if (MaNH == "")
            {
                MessageBox.Show("Đơn nhập hàng không tồn tại!");
            }
            else
            {
                int id = int.Parse(MaNH);
                DialogResult notify = MessageBox.Show("Bạn có muốn xóa phiếu nhập hàng này?", "", MessageBoxButtons.YesNo);
                if (notify == DialogResult.Yes)
                {
                    DataProvider.Instance.ExcuteNonQuery("DELETE FROM ChiTietNH WHERE MaNH = " + id);
                    NhapHangDAO.Instance.DeleteNH(id);
                }
                else
                {
                    return;
                }
                LoadNH();
            }
        }

        //Thêm, sửa, xem, xóa thống kê
        private void btnThemTK_Click(object sender, EventArgs e)
        {
            frmTK.isMainButton = "themtk";
            frmTK frmThongKe = new frmTK();
            frmThongKe.Show();
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (MaTK == "")
            {
                MessageBox.Show("Thống kê không tồn tại!");
            }
            else
            {
                frmTK.isMainButton = "suatk";
                frmTK frmThongKe = new frmTK();
                frmThongKe.Show();
            }

        }

        private void btnXemTK_Click(object sender, EventArgs e)
        {
            if (MaTK == "")
            {
                MessageBox.Show("Thống kê không tồn tại!");
            }
            else
            {
                frmTK.isMainButton = "xemtk";
                frmTK frmThongKe = new frmTK();
                frmThongKe.Show();
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (MaTK == "")
            {
                MessageBox.Show("Thống kê không tồn tại!");
            }
            else
            {
                int id = int.Parse(MaTK);
                DialogResult notify = MessageBox.Show("Bạn có muốn xóa hàng hóa này?", "", MessageBoxButtons.YesNo);
                if (notify == DialogResult.Yes)
                {
                    ThongKeDAO.Instance.DeleteTK(id);
                }
                else
                {
                    return;
                }
                LoadTK();
            }
        }

        //Thêm, sửa, xem, xóa hàng hóa
        private void btnThemHH_Click(object sender, EventArgs e)
        {
            frmHH.isMainButton = "themhh";
            frmHH frmHangHoa = new frmHH();
            frmHangHoa.Show();
        }

        private void btnSuaHH_Click(object sender, EventArgs e)
        {
            if (MaHH == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                frmHH.isMainButton = "suahh";
                frmHH frmHangHoa = new frmHH();
                frmHangHoa.Show();
            }
        }

        private void btnXemHH_Click(object sender, EventArgs e)
        {
            if (MaHH == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                frmHH.isMainButton = "xemhh";
                frmHH frmHangHoa = new frmHH();
                frmHangHoa.Show();
            }
        }

        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            if (MaHH == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                string id = MaHH;
                DialogResult notify = MessageBox.Show("Bạn có muốn xóa hàng hóa này?", "", MessageBoxButtons.YesNo);
                if (notify == DialogResult.Yes)
                {
                    HangHoaDAO.Instance.DeleteHH(id);
                }
                else
                {
                    return;
                }
                LoadHH();
            }
        }

        //Thêm, sửa, xem, xóa hóa đơn
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            frmHD.isMainButton = "themhd";
            frmHD frmHoaDon = new frmHD();
            frmHoaDon.Show();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (SoHD == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                frmHD.isMainButton = "suahd";
                frmHD frmHoaDon = new frmHD();
                frmHoaDon.Show();
            }
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            if (SoHD == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                frmHD.isMainButton = "xemhd";
                frmHD frmHoaDon = new frmHD();
                frmHoaDon.Show();
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (SoHD == "")
            {
                MessageBox.Show("Hóa đơn không tồn tại!");
            }
            else
            {
                int id = int.Parse(SoHD);
                DialogResult notify = MessageBox.Show("Bạn có muốn xóa hàng hóa này?", "", MessageBoxButtons.YesNo);
                if (notify == DialogResult.Yes)
                {
                    DataProvider.Instance.ExcuteNonQuery("DELETE FROM DonHang WHERE SoHD = " + id);
                    HoaDonDAO.Instance.DeleteHD(id);
                }
                else
                {
                    return;
                }
                LoadHD();
            }
        }

        //Trả về ID của dữ liệu trong DataGridView của các trang chức năng chính
        public static string MaNV = "";
        public static string MaNH = "";
        public static string MaTK = "";
        public static string MaHH = "";
        public static string SoHD = "";
        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MaNV = dgvNV.Rows[e.RowIndex].Cells["clMaNV"].FormattedValue.ToString();
            }
            catch (Exception) { }
        }

        private void dgvNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MaNH = dgvNH.Rows[e.RowIndex].Cells["clMaNH"].FormattedValue.ToString();
            }
            catch (Exception) { }
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MaTK = dgvTK.Rows[e.RowIndex].Cells["clIDTK"].FormattedValue.ToString();
            }
            catch (Exception) { }
            
        }

        private void dgvHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MaHH = dgvHH.Rows[e.RowIndex].Cells["clMaHH"].FormattedValue.ToString();
            }
            catch (Exception) { }
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SoHD = dgvHD.Rows[e.RowIndex].Cells["clSoHD"].FormattedValue.ToString();
            }
            catch (Exception) { }        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {

        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
