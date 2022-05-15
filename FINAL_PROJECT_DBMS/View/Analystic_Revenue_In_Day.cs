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
    public partial class Analystic_Revenue_In_Day : Form
    {
        DAOConnection db;
        public Analystic_Revenue_In_Day()
        {
            InitializeComponent();
           db =  new DAOConnection();
        }

        private void dgv_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string create_day = textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text;
            DataTable data = db.showRevenueInDay(create_day);
            if (data != null)
            {
                dgv_result.DataSource = data;
            }
            else
                MessageBox.Show("Không có dữ liệu !!!");
        }

        private void Analystic_Revenue_In_Day_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
