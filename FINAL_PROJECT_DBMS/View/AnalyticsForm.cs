using FINAL_PROJECT_DBMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT_DBMS.View
{
    public partial class AnalyticsForm : Form
    {
        private static String str_id;
        private static int int_id;
        private static int request = 0;
        private DAOConnection dbCnt;
        public AnalyticsForm()
        {
            InitializeComponent();
            dbCnt = new DAOConnection();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string choiceStr = cbx_func.Text;
            switch (choiceStr)
            {
                case "NV có kinh nghiệm làm việc( từ 2 tháng đến 3 tháng)":
                    {
                        dgv_result.DataSource = dbCnt.empOverOneMonth();
                    }
                    break;
                case "Danh sách đơn hàng chưa thanh toán":
                    {
                        dgv_result.DataSource = dbCnt.showUnpaidOrderlist();
                    }
                    break;
                case "In ra 5 sản phẩm bán chạy nhất":
                    {
                        dgv_result.DataSource = dbCnt.showRankProduct();
                    }
                    break;
                case "Phân tích chênh lệch phí duy trì cửa hàng":
                    {
                        showMessageDialog("Vui lòng nhập vào SHOP ID cần phân tích");
                    }
                    break;
                case "1":
                    {
                        dgv_result.DataSource = dbCnt.showFEE();
                    }
                    break;
                case "2":
                    {
                        dgv_result.DataSource = dbCnt.showHCMShop();
                    }
                    break;
                case "3":
                    {
                        dgv_result.DataSource = dbCnt.showVoucherTODAY();
                    }
                    break;
            }
        }

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            cbx_func.SelectedIndex = 0;

        }
        private void showMessageDialog(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
      

        private void btn_input_Click(object sender, EventArgs e)
        {
            


            }

        private void dgv_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

