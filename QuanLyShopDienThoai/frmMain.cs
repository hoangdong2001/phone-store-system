using PhoneStoreSystem.DAO;
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

namespace PhoneStoreSystem
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
            // TODO: This line of code loads data into the 'PhoneStoreSystemDataSet.Employee' table. You can move, or remove it, as needed.
            this.EmployeeTableAdapter.Fill(this.PhoneStoreSystemDataSet.Employee);
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
            string query = "SELECT EmployeeID, FullName, Gender, Position FROM Employee";
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
            string query = "SELECT ImportID, ImportDate, StatisticOutcomePhi FROM Import";
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
            string query = "SELECT ID, NgayTK, Revenue FROM Statistic";
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
            string query = "SELECT ProductID, ProductName, Quantity FROM Product";
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
            string query = "SELECT OrderNumber, CreateDate, TongTien FROM Bill";
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
            frmNV frmEmployee = new frmNV();
            frmEmployee.Show();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (EmployeeID == "")
            {
                MessageBox.Show("Nhân viên không tồn tại!");
            }
            else
            {
                frmNV.isMainButton = "suanv";
                frmNV frmEmployee = new frmNV();
                frmEmployee.Show();
            }
        }

        private void btnXemNV_Click(object sender, EventArgs e)
        {
            if (EmployeeID == "")
            {
                MessageBox.Show("Nhân viên không tồn tại!");
            }
            else
            {
                frmNV.isMainButton = "xemnv";
                frmNV frmEmployee = new frmNV();
                frmEmployee.Show();
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (EmployeeID == "")
            {
                MessageBox.Show("Nhân viên không tồn tại");
            }
            else
            {
                string id = EmployeeID;
                DialogResult notify = MessageBox.Show("Bạn có muốn xóa nhân viên này?", "", MessageBoxButtons.YesNo);
                if (notify == DialogResult.Yes)
                {
                    EmployeeDAO.Instance.DeleteNV(id);
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
            frmNH frmImport = new frmNH();
            frmImport.Show();
        }

        private void btnSuaNH_Click(object sender, EventArgs e)
        {
            if (ImportID == "")
            {
                MessageBox.Show("Đơn nhập hàng không tồn tại!");
            }
            else
            {
                frmNH.isMainButton = "suanh";
                frmNH frmImport = new frmNH();
                frmImport.Show();
            }

        }

        private void btnXemNH_Click(object sender, EventArgs e)
        {
            if (ImportID == "")
            {
                MessageBox.Show("Đơn nhập hàng không tồn tại!");
            }
            else
            {
                frmNH.isMainButton = "xemnh";
                frmNH frmImport = new frmNH();
                frmImport.Show();
            }
        }

        private void btnXoaNH_Click(object sender, EventArgs e)
        {
            if (ImportID == "")
            {
                MessageBox.Show("Đơn nhập hàng không tồn tại!");
            }
            else
            {
                int id = int.Parse(ImportID);
                DialogResult notify = MessageBox.Show("Bạn có muốn xóa phiếu nhập hàng này?", "", MessageBoxButtons.YesNo);
                if (notify == DialogResult.Yes)
                {
                    DataProvider.Instance.ExcuteNonQuery("DELETE FROM ImportDetail WHERE ImportID = " + id);
                    ImportDAO.Instance.DeleteNH(id);
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
            frmTK frmStatistic = new frmTK();
            frmStatistic.Show();
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
                frmTK frmStatistic = new frmTK();
                frmStatistic.Show();
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
                frmTK frmStatistic = new frmTK();
                frmStatistic.Show();
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
                    StatisticDAO.Instance.DeleteTK(id);
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
            frmHH frmProduct = new frmHH();
            frmProduct.Show();
        }

        private void btnSuaHH_Click(object sender, EventArgs e)
        {
            if (ProductID == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                frmHH.isMainButton = "suahh";
                frmHH frmProduct = new frmHH();
                frmProduct.Show();
            }
        }

        private void btnXemHH_Click(object sender, EventArgs e)
        {
            if (ProductID == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                frmHH.isMainButton = "xemhh";
                frmHH frmProduct = new frmHH();
                frmProduct.Show();
            }
        }

        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            if (ProductID == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                string id = ProductID;
                DialogResult notify = MessageBox.Show("Bạn có muốn xóa hàng hóa này?", "", MessageBoxButtons.YesNo);
                if (notify == DialogResult.Yes)
                {
                    ProductDAO.Instance.DeleteHH(id);
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
            frmHD frmBill = new frmHD();
            frmBill.Show();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (OrderNumber == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                frmHD.isMainButton = "suahd";
                frmHD frmBill = new frmHD();
                frmBill.Show();
            }
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            if (OrderNumber == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                frmHD.isMainButton = "xemhd";
                frmHD frmBill = new frmHD();
                frmBill.Show();
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (OrderNumber == "")
            {
                MessageBox.Show("Hóa đơn không tồn tại!");
            }
            else
            {
                int id = int.Parse(OrderNumber);
                DialogResult notify = MessageBox.Show("Bạn có muốn xóa hàng hóa này?", "", MessageBoxButtons.YesNo);
                if (notify == DialogResult.Yes)
                {
                    DataProvider.Instance.ExcuteNonQuery("DELETE FROM Order WHERE OrderNumber = " + id);
                    BillDAO.Instance.DeleteHD(id);
                }
                else
                {
                    return;
                }
                LoadHD();
            }
        }

        //Trả về ID của dữ liệu trong DataGridView của các trang chức năng chính
        public static string EmployeeID = "";
        public static string ImportID = "";
        public static string MaTK = "";
        public static string ProductID = "";
        public static string OrderNumber = "";
        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EmployeeID = dgvNV.Rows[e.RowIndex].Cells["clEmployeeID"].FormattedValue.ToString();
            }
            catch (Exception) { }
        }

        private void dgvNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ImportID = dgvNH.Rows[e.RowIndex].Cells["clImportID"].FormattedValue.ToString();
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
                ProductID = dgvHH.Rows[e.RowIndex].Cells["clProductID"].FormattedValue.ToString();
            }
            catch (Exception) { }
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                OrderNumber = dgvHD.Rows[e.RowIndex].Cells["clOrderNumber"].FormattedValue.ToString();
            }
            catch (Exception) { }        
        }
    }
}
