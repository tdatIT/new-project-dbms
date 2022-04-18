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
            }
        }

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            cbx_func.SelectedIndex = 0;

        }
    }
}
