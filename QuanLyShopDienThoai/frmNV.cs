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
    public partial class frmNV : Form
    {
        public frmNV()
        {
            InitializeComponent();
        }

        public static string isMainButton = "";
  

        //Hiển thị trang dữ liệu tương ứng với sự kiện click ở giao diện chính (frmMain)
        private void frmNV_Load(object sender, EventArgs e)
        {
            if (isMainButton == "themnv")
            {
                btnUpdateNV.Visible = false;
            }
            if (isMainButton == "suanv")
            {
                btnAddNV.Visible = false;
                txtEmployeeID.Text = frmMain.EmployeeID;
                txtEmployeeID.Enabled = false;
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM Employee WHERE EmployeeID = '" + txtEmployeeID.Text + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    txtFullNameNV.Text = dr["FullName"].ToString();
                    txtGtNV.Text = dr["Gender"].ToString();
                    txtPositionNV.Text = dr["Position"].ToString();
                    txtBirthdayNV.Text = dr["Birthday"].ToString();
                    txtPhoneNumberNV.Text = dr["PhoneNumber"].ToString();
                    txtAddressNV.Text = dr["Address"].ToString();
                }
            }
            if (isMainButton == "xemnv")
            {
                btnAddNV.Visible = false;
                btnUpdateNV.Visible = false;
                txtEmployeeID.Text = frmMain.EmployeeID;
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM Employee WHERE EmployeeID = '" + frmMain.EmployeeID + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    txtFullNameNV.Text = dr["FullName"].ToString();
                    txtGtNV.Text = dr["Gender"].ToString();
                    txtPositionNV.Text = dr["Position"].ToString();
                    txtBirthdayNV.Text = dr["Birthday"].ToString();
                    txtPhoneNumberNV.Text = dr["PhoneNumber"].ToString();
                    txtAddressNV.Text = dr["Address"].ToString();
                }
                txtEmployeeID.Enabled = false;
                txtFullNameNV.Enabled = false;
                txtGtNV.Enabled = false;
                txtPositionNV.Enabled = false;
                txtBirthdayNV.Enabled = false;
                txtPhoneNumberNV.Enabled = false;
                txtAddressNV.Enabled = false;
            }
        }

        //Thêm dữ liệu nhân viên
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            string id = txtEmployeeID.Text;
            string FullName = txtFullNameNV.Text;
            string Gender = txtGtNV.Text;
            string Position = txtPositionNV.Text;
            string Birthday = txtBirthdayNV.Text;
            string PhoneNumber = txtPhoneNumberNV.Text;
            string Address = txtAddressNV.Text;
            if (id == "")
            {
                MessageBox.Show("Vui lập nhập mã nhân viên!");
                txtEmployeeID.Focus();
            }
            else
            {
                try
                {
                    if (EmployeeDAO.Instance.InsertNV(id, FullName, Gender, Position, Birthday, PhoneNumber, Address))
                    {

                        MessageBox.Show("Thêm nhân viên thành công");
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
                }
                finally
                {
                    txtEmployeeID.Text = "";
                    txtEmployeeID.Focus();
                }
            } 
        }

        //Cập nhật dữ liệu nhân viên
        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            string id = txtEmployeeID.Text;
            string FullName = txtFullNameNV.Text;
            string Gender = txtGtNV.Text;
            string Position = txtPositionNV.Text;
            string Birthday = txtBirthdayNV.Text;
            string PhoneNumber = txtPhoneNumberNV.Text;
            string Address = txtAddressNV.Text;

            if (EmployeeDAO.Instance.UpdateNV(id,FullName, Gender, Position, Birthday, PhoneNumber, Address))
            {
                MessageBox.Show("Hoàn tất cập nhật");
                this.Hide();
            }
        }
    }
}
