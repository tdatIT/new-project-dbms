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
    public partial class Analystic_Product_in_day : Form
    {
        DAOConnection db;
        public Analystic_Product_in_day()
        {
            InitializeComponent();
            db = new DAOConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string create_day = textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text;
            DataTable data = db.showProductInDay(create_day);
            if (data != null)
            {
                dgv_result.DataSource = data;
            }
            else
                MessageBox.Show("Không có dữ liệu !!!");
        }

        private void Analystic_Product_in_day_Load(object sender, EventArgs e)
        {

        }
    }
}
