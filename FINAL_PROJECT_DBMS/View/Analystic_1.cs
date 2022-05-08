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
    public partial class Analystic_1 : Form
    {
        DAOConnection db;
        public Analystic_1()
        {
            InitializeComponent();
            db = new DAOConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string shop_id = textBox1.Text;
            DataTable data = db.showDiffBtwCost(shop_id);
            if (data != null)
            {
                dgv_result.DataSource = data;
            }
            else
                MessageBox.Show("Không có dữ liệu !!!");
        }
    }
}
