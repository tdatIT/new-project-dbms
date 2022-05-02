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
            this.db1 = new DAOConnection();
            InitializeComponent();
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {
            SqlConnection cnt = db1.getConnection();
            try
            {
                cnt.Open();
                string query = "Select emp_name FROM EMPLOYEE";
                SqlCommand cmd = new SqlCommand(query, cnt);
                SqlDataReader data = cmd.ExecuteReader();
                while(data.Read())
                {
                    cbx_Delete_Employee.Items.Add(data["emp_name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cnt.Close();
            }
        }

        private void btn_Delete_Employee_Click(object sender, EventArgs e)
        {
            string name = cbx_Delete_Employee.Text;
            if (db1.deleteEmployee(name))
            {
                MessageBox.Show("Hoàn tất", "Xóa nhân viên:" + name,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
                MessageBox.Show("Thất bại", "Xóa không thành công:" + name,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
