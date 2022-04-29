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
    public partial class DeleteEmployee : Form
    {
        private DAOConnection db1;
        public DeleteEmployee()
        {
            db1 = new DAOConnection();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SqlConnection cnt = db1.getConnection();
            try
            {
                cnt.Open();
                string query = "SELECT name emp_name FROM employee";
                SqlCommand cmd = new SqlCommand(query, cnt);
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cbx_employee_name.Items.Add(data["emp_name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                cnt.Close();
            }
         //   cbx_employee_name.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_TextChanged(object sender, EventArgs e)
        {
            string name = cbx_employee_name.Text;
            if(db1.deleteEmployee(name))
            {
                MessageBox.Show("Hoàn tất", "Xóa nhân viên:" + name, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
                MessageBox.Show("Thất bại", "Xóa không thành công:" + name,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lb_1_Click(object sender, EventArgs e)
        {

        }

        private void cbx_employee_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
