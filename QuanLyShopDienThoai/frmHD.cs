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
                    BillDAO.Instance.InsertHD(DateTime.Now);
                    txtNgayHD.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    txtOrderNumber.Text = DataProvider.Instance.ExcuteScalar("SELECT Max(OrderNumber) FROM Bill");
                    txtOrderNumber.Enabled = false;
                    txtNgayHD.Enabled = false;
                    txtProductID.Focus();
                }
                catch (Exception) { }
            }
            if (isMainButton == "suahd")
            {
                try
                {
                    btnThanhToan.Visible = false;
                    txtOrderNumber.Text = frmMain.OrderNumber;
                    dgvOrder.DataSource = DataProvider.Instance.ExcuteQuery("SELECT ProductID, ProductName, Price, Quantity, TotalPrice FROM Order WHERE OrderNumber = " + frmMain.OrderNumber);
                    DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT CreateDate, TongTien FROM Bill WHERE OrderNumber = " + int.Parse(frmMain.OrderNumber));
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtNgayHD.Text = dr["CreateDate"].ToString();
                        tvTongTien.Text = dr["TongTien"].ToString();
                    }
                    txtOrderNumber.Enabled = false;
                    txtNgayHD.Enabled = false;
                }
                catch (Exception) { }
            }
            if (isMainButton == "xemhd")
            {
                pnEditHD.Visible = false;
                try
                {
                    DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM Bill WHERE OrderNumber = " + frmMain.OrderNumber);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txtOrderNumber.Text = dr["OrderNumber"].ToString();
                            txtNgayHD.Text = dr["CreateDate"].ToString();
                            tvTongTien.Text = dr["TongTien"].ToString() + " vnđ";
                        }
                    }
                    txtOrderNumber.Enabled = false;
                    txtNgayHD.Enabled = false;
                    dgvOrder.DataSource = DataProvider.Instance.ExcuteQuery("SELECT ProductID, ProductName, Price, Quantity, TotalPrice FROM Order WHERE OrderNumber = " + int.Parse(frmMain.OrderNumber));
                }
                catch (Exception) { }
            }
        }

        //Thêm hàng hóa cho hóa đơn
        private void btnThemHH_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Nhập thông tin cho sản phẩm!");
            }
            else
            {
                try
                {
                    int OrderNumber = int.Parse(txtOrderNumber.Text);
                    string ProductID = txtProductID.Text;
                    string ProductName = tvProductName.Text;
                    float gia = float.Parse(tvPrice.Text);
                    int Quantity = int.Parse(txtQuantity.Text);
                    float TotalPrice = gia * Quantity;

                    if (OrderDAO.Instance.InsertDH(OrderNumber, ProductID, ProductName, gia, Quantity, TotalPrice))
                    {
                        string query = "UPDATE Product SET Quantity -=" + Quantity + " WHERE ProductID = '" + ProductID + "'";
                        DataProvider.Instance.ExcuteNonQuery(query);
                        dgvOrder.DataSource = DataProvider.Instance.ExcuteQuery("SELECT ProductID, ProductName, Price, Quantity, TotalPrice FROM Order WHERE OrderNumber = " + int.Parse(txtOrderNumber.Text));
                    }
                }
                catch (Exception) { }             
            }
        }

        //Xóa hàng hóa khỏi hóa đơn
        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            if (ProductID == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                try
                {
                    string id = ProductID;
                    OrderDAO.Instance.DeleteDH(id);
                    dgvOrder.DataSource = DataProvider.Instance.ExcuteQuery("SELECT ProductID,ProductName,Price,Quantity,TotalPrice FROM Order WHERE OrderNumber = " + int.Parse(txtOrderNumber.Text));
                }
                catch (Exception) { }            
            }
        }

        private void txtProductID_Leave(object sender, EventArgs e)
        {
            string ProductID = txtProductID.Text;
            DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM Product WHERE ProductID = '" + ProductID + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    tvProductName.Text = dr["ProductName"].ToString();
                    tvPrice.Text = dr["ProductPrice"].ToString();
                }
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            float gia = float.Parse(tvPrice.Text);
            int Quantity = 0;
            if (txtQuantity.Text != "")
            {
                Quantity = int.Parse(txtQuantity.Text);
            }
            float TotalPrice = gia * Quantity;
            tvTotalPrice.Text = TotalPrice.ToString();
        }

        //Thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int OrderNumber = int.Parse(txtOrderNumber.Text);
                string tongtien = DataProvider.Instance.ExcuteScalar("SELECT SUM(TotalPrice) FROM Order WHERE OrderNumber = " + OrderNumber);
                DataProvider.Instance.ExcuteNonQuery("UPDATE Bill SET TongTien = " + tongtien + " WHERE OrderNumber = " + OrderNumber);
                tvTongTien.Text = tongtien + " vnđ";
            }
            catch (Exception) { }
        }

        //Cập nhật hóa đơn
        private void btnUpdateHD_Click(object sender, EventArgs e)
        {
            try
            {
                int OrderNumber = int.Parse(txtOrderNumber.Text);
                string tongtien = DataProvider.Instance.ExcuteScalar("SELECT SUM(TotalPrice) FROM Order WHERE OrderNumber = " + OrderNumber);
                DataProvider.Instance.ExcuteNonQuery("UPDATE Bill SET TongTien = " + tongtien + " WHERE OrderNumber = " + OrderNumber);
                tvTongTien.Text = tongtien + " vnđ";
                MessageBox.Show("Đã cập nhật!");
            }
            catch (Exception) 
            {
                int OrderNumber = int.Parse(txtOrderNumber.Text);
                tvTongTien.Text = "";
                MessageBox.Show("Đã cập nhật!");
                DataProvider.Instance.ExcuteNonQuery("UPDATE Bill SET TongTien = NULL WHERE OrderNumber = " + OrderNumber);
            }
            this.Hide();
        }

        public string ProductID = "";
        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProductID = dgvOrder.Rows[e.RowIndex].Cells["clProductID"].FormattedValue.ToString();
            }
            catch (Exception) { }
        }
    }
}
