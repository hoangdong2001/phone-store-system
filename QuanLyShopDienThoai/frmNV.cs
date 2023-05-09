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
                txtMaNV.Text = frmMain.MaNV;
                txtMaNV.Enabled = false;
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM NhanVien WHERE MaNV = '" + txtMaNV.Text + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    txtHotenNV.Text = dr["Hoten"].ToString();
                    txtGtNV.Text = dr["Gioi"].ToString();
                    txtChucvuNV.Text = dr["ChucVu"].ToString();
                    txtNamsinhNV.Text = dr["NamSinh"].ToString();
                    txtSdtNV.Text = dr["SDT"].ToString();
                    txtDiachiNV.Text = dr["DiaChi"].ToString();
                }
            }
            if (isMainButton == "xemnv")
            {
                btnAddNV.Visible = false;
                btnUpdateNV.Visible = false;
                txtMaNV.Text = frmMain.MaNV;
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM NhanVien WHERE MaNV = '" + frmMain.MaNV + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    txtHotenNV.Text = dr["Hoten"].ToString();
                    txtGtNV.Text = dr["Gioi"].ToString();
                    txtChucvuNV.Text = dr["ChucVu"].ToString();
                    txtNamsinhNV.Text = dr["NamSinh"].ToString();
                    txtSdtNV.Text = dr["SDT"].ToString();
                    txtDiachiNV.Text = dr["DiaChi"].ToString();
                }
                txtMaNV.Enabled = false;
                txtHotenNV.Enabled = false;
                txtGtNV.Enabled = false;
                txtChucvuNV.Enabled = false;
                txtNamsinhNV.Enabled = false;
                txtSdtNV.Enabled = false;
                txtDiachiNV.Enabled = false;
            }
        }

        //Thêm dữ liệu nhân viên
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            string id = txtMaNV.Text;
            string hoten = txtHotenNV.Text;
            string gioi = txtGtNV.Text;
            string chucvu = txtChucvuNV.Text;
            string namsinh = txtNamsinhNV.Text;
            string sdt = txtSdtNV.Text;
            string diachi = txtDiachiNV.Text;
            if (id == "")
            {
                MessageBox.Show("Vui lập nhập mã nhân viên!");
                txtMaNV.Focus();
            }
            else
            {
                try
                {
                    if (NhanVienDAO.Instance.InsertNV(id, hoten, gioi, chucvu, namsinh, sdt, diachi))
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
                    txtMaNV.Text = "";
                    txtMaNV.Focus();
                }
            } 
        }

        //Cập nhật dữ liệu nhân viên
        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            string id = txtMaNV.Text;
            string hoten = txtHotenNV.Text;
            string gioi = txtGtNV.Text;
            string chucvu = txtChucvuNV.Text;
            string namsinh = txtNamsinhNV.Text;
            string sdt = txtSdtNV.Text;
            string diachi = txtDiachiNV.Text;

            if (NhanVienDAO.Instance.UpdateNV(id,hoten, gioi, chucvu, namsinh, sdt, diachi))
            {
                MessageBox.Show("Hoàn tất cập nhật");
                this.Hide();
            }
        }
    }
}
