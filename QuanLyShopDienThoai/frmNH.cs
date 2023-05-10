using PhoneStoreSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStoreSystem
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
                txtImportID.Enabled = false;
                txtImportDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
                txtImportDate.Enabled = false;
            }
            if (isMainButton == "suanh")
            {
                txtImportID.Text = frmMain.ImportID;
                txtImportID.Enabled = false;
                btnTaoNH.Enabled = false;
                DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT ImportDate FROM Import WHERE ImportID = " + int.Parse(frmMain.ImportID));
                foreach (DataRow dr in dt.Rows)
                {
                    txtImportDate.Text = dr["ImportDate"].ToString();
                }
                txtImportDate.Enabled = false;
                btnAddNH.Visible = false;
                dgvImportDetail.DataSource = DataProvider.Instance.ExcuteQuery("SELECT ProductID,ProductName,Price,Quantity,TotalPrice FROM ImportDetail WHERE ImportID = "+ int.Parse(frmMain.ImportID));
            }
            if (isMainButton == "xemnh")
            {
                pnEditNH.Visible = false;
                btnTaoNH.Visible = false;
                DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM Import WHERE ImportID = " + frmMain.ImportID);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtImportID.Text = dr["ImportID"].ToString();
                        txtImportDate.Text = dr["ImportDate"].ToString();
                    }
                }
                txtImportID.Enabled = false;
                txtImportDate.Enabled = false;
                dgvImportDetail.DataSource = DataProvider.Instance.ExcuteQuery("SELECT ProductID,ProductName,Price,Quantity,TotalPrice FROM ImportDetail WHERE ImportID = " + int.Parse(frmMain.ImportID));
            }
        }

        //Kiểm tra và trả về dữ liệu của hàng hóa
        private void btnKtraNH_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Nhập mã hàng hóa!");
                txtProductID.Focus();
            }
            else
            {
                string ProductID = txtProductID.Text;
                DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM Product WHERE ProductID = " + ProductID);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtProductName.Text = dr["ProductName"].ToString();
                        txtProductOrigin.Text = dr["ProductOrigin"].ToString();
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
                int ImportID = int.Parse(txtImportID.Text);
                string tongtien = DataProvider.Instance.ExcuteScalar("SELECT SUM(TotalPrice) FROM ImportDetail WHERE ImportID = " + ImportID);
                DataProvider.Instance.ExcuteNonQuery("UPDATE Import SET StatisticOutcomePhi = " + tongtien + " WHERE ImportID = " + ImportID);
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
                int ImportID = int.Parse(txtImportID.Text);
                string tongtien = DataProvider.Instance.ExcuteScalar("SELECT SUM(TotalPrice) FROM ImportDetail WHERE ImportID = " + ImportID);
                DataProvider.Instance.ExcuteNonQuery("UPDATE Import SET StatisticOutcomePhi = " + tongtien + " WHERE ImportID = " + ImportID);
            }
            catch (Exception) 
            {
                int ImportID = int.Parse(txtImportID.Text);
                string tongtien = "";
                DataProvider.Instance.ExcuteNonQuery("UPDATE Import SET StatisticOutcomePhi = NULL  WHERE ImportID = " + ImportID);
                dgvImportDetail.DataSource = DataProvider.Instance.ExcuteQuery("SELECT ProductID,ProductName,Price,Quantity,TotalPrice FROM ImportDetail WHERE ImportID = " + ImportID);
            }
            this.Hide();
        }

        //Thêm hàng hóa vào đơn nhập hàng
        private void btnThemHH_Click(object sender, EventArgs e)
        {
            if (txtImportID.Text == "")
            {
                MessageBox.Show("Hãy tạo phiếu nhập hàng!");
            }    
            else if (txtProductID.Text == "" || txtProductName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin cần thiết!");
            }
            else
            {
                int ImportID = int.Parse(txtImportID.Text);
                string ProductID = txtProductID.Text;
                string ProductName = txtProductName.Text;
                string ProductOrigin = txtProductOrigin.Text;
                float giatien = float.Parse(txtPrice.Text);
                int Quantity = int.Parse(txtQuantity.Text);
                float TotalPrice = giatien * Quantity;
                try
                {
                    if (ImportDetailDAO.Instance.InsertCTNH(ImportID, ProductID, ProductName, ProductOrigin, giatien, Quantity, TotalPrice))
                    {
                        string query = "UPDATE Product SET Quantity +=" + Quantity + " WHERE ProductID = '" + ProductID + "'";
                        DataProvider.Instance.ExcuteNonQuery(query);
                        dgvImportDetail.DataSource = DataProvider.Instance.ExcuteQuery("SELECT ProductID,ProductName,Price,Quantity,TotalPrice FROM ImportDetail WHERE ImportID = " + int.Parse(txtImportID.Text));
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
            if (ProductID == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                string id = ProductID;
                ImportDetailDAO.Instance.DeleteCTNH(id);
                dgvImportDetail.DataSource = DataProvider.Instance.ExcuteQuery("SELECT ProductID,ProductName,Price,Quantity,TotalPrice FROM ImportDetail");
            }
        }

        //Tạo đơn nhập hàng 
        private void btnTaoNH_Click(object sender, EventArgs e)
        {
            int ImportID = 0;
            if (DataProvider.Instance.ExcuteScalar("SELECT Max(ImportID) FROM Import") == "")
            {
                txtImportID.Text = "1";
                ImportID = int.Parse(txtImportID.Text);
                ImportDAO.Instance.InsertNH(ImportID, DateTime.Today);
            }
            else
            {
                string tmp = DataProvider.Instance.ExcuteScalar("SELECT Max(ImportID) FROM Import");
                ImportID = int.Parse(tmp) + 1;
                txtImportID.Text = ImportID.ToString();
                txtImportDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
                ImportDAO.Instance.InsertNH(ImportID, DateTime.Today);
            }    
        }

        //Trả về mã hàng hóa của hàng hóa được chọn trong StatisticOutcome tiết đơn nhập hàng
        public static string ProductID = "";
        private void dgvImportDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProductID = dgvImportDetail.Rows[e.RowIndex].Cells["clProductID"].FormattedValue.ToString();
            }
            catch (Exception) { }
        }
    }
}
