using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FINAL_PROJECT_DBMS.Model;

namespace FINAL_PROJECT_DBMS.Model
{
    public partial class AnalysticTotalPayment : Form
    {
        DAOConnection db;
        public AnalysticTotalPayment()
        {
            InitializeComponent();
            db = new DAOConnection();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string shopID = textBox1.Text;
            DataTable data = db.showTotalPayment(shopID);
            if (data != null)
            {
                dgv_result.DataSource = data;
            }
            else
                MessageBox.Show("Không có dữ liệu !!!");
        }

        private void AnalysticTotalPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
