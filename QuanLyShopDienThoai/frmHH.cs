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
    public partial class frmHH : Form
    {
        public frmHH()
        {
            InitializeComponent();
        }
        public static string isMainButton = "";

        //Hiển thị giao diện dữ lieuj tương ứng với sự kiện click ở giao diện chính (frmMain)
        private void frmHH_Load(object sender, EventArgs e)
        {
            if (isMainButton == "themhh")
            {
                btnUpdateHH.Visible = false;
            }
            if (isMainButton == "suahh")
            {
                btnAddHH.Visible = false;
                txtProductID.Text = frmMain.ProductID;
                txtProductID.Enabled = false;
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM Product WHERE ProductID = '" + frmMain.ProductID + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    txtProductName.Text = dr["ProductName"].ToString();
                    txtProductOrigin.Text = dr["ProductOrigin"].ToString();
                    txtProductPrice.Text = dr["ProductPrice"].ToString();
                    txtQuantityHH.Text = dr["Quantity"].ToString();
                }
            }
            if (isMainButton == "xemhh")
            {
                btnAddHH.Visible = false;
                btnUpdateHH.Visible = false;
                txtProductID.Text = frmMain.ProductID;
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM Product WHERE ProductID = '" + frmMain.ProductID + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    txtProductName.Text = dr["ProductName"].ToString();
                    txtProductOrigin.Text = dr["ProductOrigin"].ToString();
                    txtProductPrice.Text = dr["ProductPrice"].ToString();
                    txtQuantityHH.Text = dr["Quantity"].ToString();
                }
                txtProductID.Enabled = false;
                txtProductName.Enabled = false;
                txtProductOrigin.Enabled = false;
                txtProductPrice.Enabled = false;
                txtQuantityHH.Enabled = false;
            }
        }

        //Thêm hàng hóa
        private void btnAddHH_Click(object sender, EventArgs e)
        {
            string id = txtProductID.Text;
            string ProductName = txtProductName.Text;
            string ProductOrigin = txtProductOrigin.Text;
            float gb = 0;
            int s = 0;
            if (txtProductPrice.Text != "") { gb = float.Parse(txtProductPrice.Text);}
            if (txtQuantityHH.Text != "") { s = int.Parse(txtQuantityHH.Text); }
            float ProductPrice = gb;
            int Quantity = s;

            if (id == "")
            {
                MessageBox.Show("Vui lập nhập mã hàng hóa!");
                txtProductID.Focus();
            }
            else
            {
                try
                {
                    if (ProductDAO.Instance.InsertHH(id, ProductName, ProductOrigin,ProductPrice,Quantity))
                    {
                        MessageBox.Show("Thêm hàng hóa thành công!");
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã hàng hóa đã tồn tại!");
                }
                finally
                {
                    txtProductID.Text = "";
                    txtProductID.Focus();
                }
            }
        }

        //Cập nhật thông tin hàng hóa
        private void btnUpdateHH_Click(object sender, EventArgs e)
        {
            string id = txtProductID.Text;
            string ProductName = txtProductName.Text;
            string ProductOrigin = txtProductOrigin.Text;
            float ProductPrice = float.Parse(txtProductPrice.Text);
            int Quantity = int.Parse(txtQuantityHH.Text);

            if (ProductDAO.Instance.UpdateHH(id, ProductName, ProductOrigin, ProductPrice, Quantity))
            {
                MessageBox.Show("Hoàn tất cập nhật!");
                this.Hide();
            }
        }
    }
}
