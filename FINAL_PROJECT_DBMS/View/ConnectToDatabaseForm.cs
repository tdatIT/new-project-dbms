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
    public partial class ConnectToDatabaseForm : Form
    {
        public static string USER;
        public static string PASS;
        public static string DB_URL = "Data Source=localhost;Initial Catalog=DBMS_FINAL_PROJECT;";
        public static string CNT_STR;
       
        public ConnectToDatabaseForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConnectToDatabaseForm_Load(object sender, EventArgs e)
        {
            txt_cnt.Text = DB_URL;
        }
        private bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            USER = txt_username.Text;
            PASS = txt_pass.Text;
            DB_URL = txt_cnt.Text;
            CNT_STR = DB_URL + "User ID=" + USER + ";Password=" + PASS;
            if (IsServerConnected(CNT_STR))
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
                DAOConnection.cntStr = CNT_STR;
            }
            else
                MessageBox.Show("Kết nối thất bại kiểm tra lại thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void chkbox_default_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_default.Checked == true)
                txt_cnt.ReadOnly = true;
            else
                txt_cnt.ReadOnly = false;
        }
    }
}
