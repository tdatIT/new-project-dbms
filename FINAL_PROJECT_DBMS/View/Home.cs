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
    public partial class Home : Form
    {
        private DAOConnection cnt = null;
        private string user_root;
        public Home(string user)
        {
            InitializeComponent();
            cnt = new DAOConnection();
            this.user_root = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString();
            SqlConnection sqlCnt = cnt.getConnection();
            string query = "SELECT * FROM EMPLOYEE WHERE username=@user";
            sqlCnt.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCnt);
            cmd.Parameters.AddWithValue("@user", user_root);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_name.Text += dr["emp_name"].ToString();
                txt_id.Text += dr["emp_id"].ToString();
                txt_username.Text += dr["username"].ToString();
                txt_begindate.Text += dr["begin_date"].ToString();
                txt_role.Text += dr["emp_role"].ToString();
                txt_phone.Text += dr["phone_number"].ToString();
                txt_pass.Text += dr["password"].ToString();
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
