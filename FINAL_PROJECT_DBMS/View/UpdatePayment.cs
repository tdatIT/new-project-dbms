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
    public partial class UpdatePayment : Form
    {
        private DAOConnection db;
        public UpdatePayment()
        {
            db = new DAOConnection();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_id.Text);
            SqlConnection cnt = db.getConnection();
            string query = "SELECT * FROM payment WHERE order_id = @id";
            SqlCommand cmd = new SqlCommand(query, cnt);
            cmd.Parameters.AddWithValue("@id", id);
            cnt.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                   
                    txt_price.Text = rd["payment_amount"].ToString();
                    comboBox1.SelectedText = rd["payment_status"].ToString();
                    cbx_type.SelectedText = rd["payment_method"].ToString();
                }
                pn_info.Enabled = true;
            }
            else
                MessageBox.Show("Không tìm thấy mã đơn hàng");
            cnt.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_id.Text);
            double price = Double.Parse(txt_price.Text);
            string payment_method = (cbx_type.Text);
            string payment_status = (comboBox1.Text);
            if (db.updatePayment(payment_method,payment_status,price,id))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                Dispose();
            }
            else
                MessageBox.Show("Cập nhật thất bại");
        }
    
    }
}
