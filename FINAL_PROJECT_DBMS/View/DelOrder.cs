using FINAL_PROJECT_DBMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT_DBMS.View
{
    public partial class DelOrder : Form
    {
        private DAOConnection db;
        public DelOrder()
        {
            db = new DAOConnection();
            InitializeComponent();
        }

        private void DelOrder_Load(object sender, EventArgs e)
        {
            showDataInTable();
        }
        private void showDataInTable()
        {
            SqlConnection cnt = db.getConnection();
            string query = "SELECT * FROM order_list";
            try
            {
                SqlDataAdapter apt = new SqlDataAdapter(query, cnt);
                DataTable table = new DataTable();
                apt.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            int order_id = Int32.Parse(textBox1.Text);
            if (db.delOrder(order_id))
            {
                MessageBox.Show("Xóa thành công");
                showDataInTable();
            }
            else
                MessageBox.Show("Xóa thành công");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
