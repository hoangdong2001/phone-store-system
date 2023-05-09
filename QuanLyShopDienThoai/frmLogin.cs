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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private string getID(string account, string password)
        {
            string id = "";
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM UserSystem  WHERE Account ='" + account + "' and password='" + password + "'";
                dt = DataProvider.Instance.ExcuteQuery(query);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["ID"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dư liệu truy cập");
            }
            return id;

        }
        public string IsLogin = "";
        public string permission;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strAccount = txtAcc.Text.Trim();
            string strPassword = txtPas.Text.Trim();
            if ((strAccount == string.Empty) && (strPassword == string.Empty))
            {
                tvNofication.Text = "Vui lòng điền thông tin đăng nhập!";
                txtAcc.Focus();
            }else if ((strAccount == string.Empty) && (strPassword != string.Empty))
            {
                tvNofication.Text = "Bạn chưa nhập tài khoản!";
                txtAcc.Focus();
            }else if ((strAccount != string.Empty) && (strPassword == string.Empty))
            {
                tvNofication.Text = "Bạn chưa nhập mật khẩu!";
                txtPas.Focus();
            }
            else
            {
                char[] spec_ch = new char[] { '~','!','@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', '=', '{', '}','[', ']', ':', ';', '"', '<', '>', ',', '?', '/' };
                IsLogin = getID(strAccount, strPassword);
                foreach (char sc in spec_ch)
                {
                    for (int i = 0; i<strPassword.Length; i++)
                    {
                        if (strPassword[i] == sc)
                        {
                            IsLogin = "";
                        }
                    }
                }
                if (IsLogin == "")
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                    txtAcc.Text = "";
                    txtPas.Text = "";
                    txtAcc.Focus();
                }
                else
                {
                    frmMain.permission = strAccount;
                    this.Hide();
                    frmMain formMain = new frmMain();
                    formMain.Show();
                }
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
