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
    public partial class Analystic_Voucher : Form
    {
        DAOConnection db;
        public Analystic_Voucher()
        {
            InitializeComponent();
            db = new DAOConnection();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            int month = Int32.Parse(textBox1.Text);
            DataTable data = db.showcountvoucherinmonth(month);
            if (data != null)
                {
                dgv_result.DataSource = data;
            }
            else
                MessageBox.Show("Không truy xuất được dữ liệu !!!");
        }

        private void dgv_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
