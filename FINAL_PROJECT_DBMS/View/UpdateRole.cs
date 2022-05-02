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
    public partial class UpdateRole : Form
    {
        private DAOConnection db;
        public UpdateRole()
        {
            InitializeComponent();
            db = new DAOConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_id.Text);
            SqlConnection cnt = db.getConnection();
            string query = "SELECT emp_name,emp_role FROM employee WHERE emp_ID = @id";
            SqlCommand cmd = new SqlCommand(query, cnt);
            cmd.Parameters.AddWithValue("@id", id);
            cnt.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    txt_name.Text = rd["emp_name"].ToString();
                    comboBox1.SelectedText = rd["emp_role"].ToString();
                }
                panel1.Enabled = true;
            }
            else
                MessageBox.Show("Không tìm thấy nhân viên phù hợp");
            cnt.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_id.Text);
            string role = comboBox1.Text;
            if (db.updateRole(id,role))
                MessageBox.Show("Cập nhật thành công");
            else
                MessageBox.Show("Cập nhật thất bại");
        }
    }
}
