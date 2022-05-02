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
    public partial class UpdateProduct : Form
    {
        private DAOConnection db;
        public UpdateProduct()
        {
            db = new DAOConnection();
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_id.Text);
            SqlConnection cnt = db.getConnection();
            string query = "SELECT * FROM products WHERE product_id = @id";
            SqlCommand cmd = new SqlCommand(query, cnt);
            cmd.Parameters.AddWithValue("@id", id);
            cnt.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    txt_name.Text = rd["name_product"].ToString();
                    txt_price.Text = rd["cost"].ToString();
                    txt_cost.Text = rd["production_cost"].ToString();
                    cbx_type.Text = rd["type"].ToString();
                }
                pn_info.Enabled = true;
            }
            else
                MessageBox.Show("Không tìm thấy mã sản phẩm phù hợp");
            cnt.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_id.Text);
            double price = Double.Parse(txt_price.Text);
            double production_cost = Double.Parse(txt_cost.Text);
            if (db.updateProduct(id, price, production_cost))
            {
                MessageBox.Show("Sửa dữ liệu thành công");
                Dispose();
            }
            else
                MessageBox.Show("Cập nhật thất bại");
        }
    }
}
