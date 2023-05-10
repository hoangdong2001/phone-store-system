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
                StatisticDAO.Instance.InsertTK(DateTime.Now);
                txtNgayTK.Text = DateTime.Today.ToString("dd/MM/yyyy hh:mm:ss");
                month = DateTime.Today.Month;
                year = DateTime.Today.Year;
                txtMaTK.Text = DataProvider.Instance.ExcuteScalar("SELECT Max(ID) FROM Statistic");
                txtMaTK.Enabled = false;
                txtNgayTK.Enabled = false;
            }
            if (isMainButton == "suatk")
            {
                btnAddTK.Visible = false;
                month = int.Parse(DataProvider.Instance.ExcuteScalar("SELECT MONTH(NgayTK) FROM Statistic WHERE ID =" + int.Parse(frmMain.MaTK)));
                year = int.Parse(DataProvider.Instance.ExcuteScalar("SELECT YEAR(NgayTK) FROM Statistic WHERE ID =" + int.Parse(frmMain.MaTK)));
                try
                {
                    DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM Statistic WHERE ID = " + int.Parse(frmMain.MaTK));
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txtMaTK.Text = dr["ID"].ToString();
                            txtNgayTK.Text = dr["NgayTK"].ToString();
                            txtStatisticIncome.Text = dr["StatisticIncome"].ToString();
                            txtStatisticOutcome.Text = dr["StatisticOutcome"].ToString();
                            txtRevenue.Text = dr["Revenue"].ToString();
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
                    DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM Statistic WHERE ID = " + int.Parse(frmMain.MaTK));
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txtMaTK.Text = dr["ID"].ToString();
                            txtNgayTK.Text = dr["NgayTK"].ToString();
                            txtStatisticIncome.Text = dr["StatisticIncome"].ToString();
                            txtStatisticOutcome.Text = dr["StatisticOutcome"].ToString();
                            txtRevenue.Text = dr["Revenue"].ToString();
                        }
                        txtMaTK.Enabled = false;
                        txtNgayTK.Enabled = false;
                        txtStatisticIncome.Enabled = false;
                        txtStatisticOutcome.Enabled = false;
                        txtRevenue.Enabled = false;
                    }
                }
                catch (Exception) { }
            }
        }

        //Trả về dữ liệu StatisticIncome, StatisticOutcome, doanh StatisticIncome của phiếu thống kê theo tháng kề trước tháng hiện tại
        private void btnKtraTK_Click(object sender, EventArgs e)
        {
            string StatisticIncome = "";
            string StatisticOutcome = "";
            float Revenue = 0;
            try
            {
                int id = int.Parse(txtMaTK.Text);
                if (month == 1)
                {
                    year = year - 1;
                    month = 12;
                    StatisticIncome = DataProvider.Instance.ExcuteScalar("SELECT SUM(TongTien) FROM Bill WHERE Year(CreateDate) =" + year.ToString() + "AND Month(CreateDate) = " + month.ToString());
                    StatisticOutcome = DataProvider.Instance.ExcuteScalar("SELECT SUM(StatisticOutcomePhi) FROM Import WHERE Year(ImportDate) =" + year.ToString() + "AND Month(ImportDate) = " + month.ToString());
                    if (StatisticIncome == "" && StatisticOutcome != "")
                    {
                        StatisticIncome = "0";
                        Revenue = 0 - float.Parse(StatisticOutcome);
                        StatisticDAO.Instance.UpdateTK(id, 0, float.Parse(StatisticOutcome), Revenue);
                    }
                    else if (StatisticIncome != "" && StatisticOutcome == "")
                    {
                        StatisticOutcome = "0";
                        Revenue = float.Parse(StatisticIncome);
                        StatisticDAO.Instance.UpdateTK(id, float.Parse(StatisticIncome), 0, Revenue);
                    }
                    else
                    {
                        Revenue = float.Parse(StatisticIncome) - float.Parse(StatisticOutcome);
                        StatisticDAO.Instance.UpdateTK(id, float.Parse(StatisticIncome), float.Parse(StatisticOutcome), Revenue);
                    }
                }
                else
                {
                    month = month - 1;
                    StatisticIncome = DataProvider.Instance.ExcuteScalar("SELECT SUM(TongTien) FROM Bill WHERE Year(CreateDate) =" + year.ToString() + "AND Month(CreateDate) = " + month.ToString());
                    StatisticOutcome = DataProvider.Instance.ExcuteScalar("SELECT SUM(StatisticOutcomePhi) FROM Import WHERE Year(ImportDate) =" + year.ToString() + "AND Month(ImportDate) = " + month.ToString());
                    if (StatisticIncome == "" && StatisticOutcome != "")
                    {
                        StatisticIncome = "0";
                        Revenue = 0 - float.Parse(StatisticOutcome);
                        StatisticDAO.Instance.UpdateTK(id, 0, float.Parse(StatisticOutcome), Revenue);
                    }
                    else if (StatisticIncome != "" && StatisticOutcome == "")
                    {
                        StatisticOutcome = "0";
                        Revenue = float.Parse(StatisticIncome);
                        StatisticDAO.Instance.UpdateTK(id, float.Parse(StatisticIncome), 0, Revenue);
                    }
                    else
                    {
                        Revenue = float.Parse(StatisticIncome) - float.Parse(StatisticOutcome);
                        StatisticDAO.Instance.UpdateTK(id, float.Parse(StatisticIncome), float.Parse(StatisticOutcome), Revenue);
                    }
                }
                txtStatisticIncome.Text = StatisticIncome;
                txtStatisticOutcome.Text = StatisticOutcome;
                txtRevenue.Text = Revenue.ToString();
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
                float StatisticIncome = float.Parse(txtStatisticIncome.Text);
                float StatisticOutcome = float.Parse(txtStatisticOutcome.Text);
                float Revenue = StatisticIncome - StatisticOutcome;
                txtRevenue.Text = Revenue.ToString();
                StatisticDAO.Instance.UpdateTK(id, StatisticIncome, StatisticOutcome, Revenue);
                MessageBox.Show("Đã cập nhật");
            }
            catch (Exception) { }
            this.Hide();
        }

        //Thêm phiếu thống kê
        private void btnAddTK_Click(object sender, EventArgs e)
        {
            if (txtStatisticIncome.Text == "" && txtStatisticOutcome.Text == "" && txtRevenue.Text == "")
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
