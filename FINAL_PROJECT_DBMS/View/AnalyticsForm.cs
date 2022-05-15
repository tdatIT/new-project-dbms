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
                        Analystic_1 analystic_1 = new Analystic_1();
                        analystic_1.Visible = true;
                    }
                    break;
                case "Xem doanh thu, lợi nhuận của cửa hàng":
                    {
                        Analystic_2 analystic_2 = new Analystic_2();
                        analystic_2.Visible = true;
                    }
                    break;
                case "Thống kê voucher được sử dụng trong tháng":
                    {
                        Analystic_Voucher Analystic_Voucher = new Analystic_Voucher();
                        Analystic_Voucher.Visible = true;
                    }
                    break;
                case "Tổng chi phí 3 tháng gần nhất":
                    {
                        dgv_result.DataSource = dbCnt.showFee();
                    }
                    break;
                case "Những chuỗi chi nhánh ở TP.HCM":
                    {
                        dgv_result.DataSource = dbCnt.showHcmShop();
                    }
                    break;
                case "Voucher có thể sử dụng trong ngày":
                    {
                        dgv_result.DataSource = dbCnt.showVoucherToday();
                    }
                    break;
                case "Xem số tiền khách hàng thanh toán":
                    {
                        AnalysticTotalPayment Total = new AnalysticTotalPayment();
                        Total.Visible = true;
                    }
                    break;
                case "Sản phẩm bán chạy của từng cửa hàng":
                    {
                        AnalysticProductBest Best = new AnalysticProductBest();
                        Best.Visible = true;
                    }
                    break;
                case "Doanh thu trong ngày":
                    {
                        Analystic_Revenue_In_Day Revenue = new Analystic_Revenue_In_Day();
                        Revenue.Visible = true;
                    }
                    break;
                case "Sản phẩm đã bán trong ngày":
                    {
                        Analystic_Product_in_day Product = new Analystic_Product_in_day();
                        Product.Visible = true;
                    }
                    break;

            }
        }

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            cbx_func.SelectedIndex = 0;

        }

        private void cbx_func_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
