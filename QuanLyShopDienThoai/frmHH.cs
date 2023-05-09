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
                txtMaHH.Text = frmMain.MaHH;
                txtMaHH.Enabled = false;
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM HangHoa WHERE MaHH = '" + frmMain.MaHH + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    txtTenHH.Text = dr["TenHH"].ToString();
                    txtXuatxu.Text = dr["XuatXu"].ToString();
                    txtGiaban.Text = dr["GiaBan"].ToString();
                    txtSLHH.Text = dr["SL"].ToString();
                }
            }
            if (isMainButton == "xemhh")
            {
                btnAddHH.Visible = false;
                btnUpdateHH.Visible = false;
                txtMaHH.Text = frmMain.MaHH;
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM HangHoa WHERE MaHH = '" + frmMain.MaHH + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    txtTenHH.Text = dr["TenHH"].ToString();
                    txtXuatxu.Text = dr["XuatXu"].ToString();
                    txtGiaban.Text = dr["GiaBan"].ToString();
                    txtSLHH.Text = dr["SL"].ToString();
                }
                txtMaHH.Enabled = false;
                txtTenHH.Enabled = false;
                txtXuatxu.Enabled = false;
                txtGiaban.Enabled = false;
                txtSLHH.Enabled = false;
            }
        }

        //Thêm hàng hóa
        private void btnAddHH_Click(object sender, EventArgs e)
        {
            string id = txtMaHH.Text;
            string tenhh = txtTenHH.Text;
            string xuatxu = txtXuatxu.Text;
            float gb = 0;
            int s = 0;
            if (txtGiaban.Text != "") { gb = float.Parse(txtGiaban.Text);}
            if (txtSLHH.Text != "") { s = int.Parse(txtSLHH.Text); }
            float giaban = gb;
            int sl = s;

            if (id == "")
            {
                MessageBox.Show("Vui lập nhập mã hàng hóa!");
                txtMaHH.Focus();
            }
            else
            {
                try
                {
                    if (HangHoaDAO.Instance.InsertHH(id, tenhh, xuatxu,giaban,sl))
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
                    txtMaHH.Text = "";
                    txtMaHH.Focus();
                }
            }
        }

        //Cập nhật thông tin hàng hóa
        private void btnUpdateHH_Click(object sender, EventArgs e)
        {
            string id = txtMaHH.Text;
            string tenhh = txtTenHH.Text;
            string xuatxu = txtXuatxu.Text;
            float giaban = float.Parse(txtGiaban.Text);
            int sl = int.Parse(txtSLHH.Text);

            if (HangHoaDAO.Instance.UpdateHH(id, tenhh, xuatxu, giaban, sl))
            {
                MessageBox.Show("Hoàn tất cập nhật!");
                this.Hide();
            }
        }
    }
}
