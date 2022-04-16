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
    public partial class Add_NewEmp : Form
    {
        private DAOConnection cnt = null;
        public Add_NewEmp()
        {
            InitializeComponent();
            cnt = new DAOConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string pass = txt_pass.Text;
            string role = cbx_role.Text;
            string name = txt_name.Text;
            string phone = txt_phone.Text;
            string shop = cbx_shop.Text;
            string date = txt_year.Text + "-" + txt_month.Text + "-" + txt_day.Text;
            if (cnt.addNewEmp(name, phone, role, date, shop, username, pass))
            {
                MessageBox.Show("Đăng ký nhân viên thành công",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
                MessageBox.Show("Thất bại: Kiểm tra lại thông tin", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


           
        }

        private void Add_NewEmp_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCnt = cnt.getConnection();
            string query = "SELECT shop_id FROM SHOP";
            sqlCnt.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCnt);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                cbx_shop.Items.Add(data["shop_id"]);
            }
            sqlCnt.Close();
        }
    }
}
