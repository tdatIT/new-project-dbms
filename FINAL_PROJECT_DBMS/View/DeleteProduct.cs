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
    public partial class DeleteProduct : Form
    {
        private DAOConnection db;
        public DeleteProduct()
        {
            db = new DAOConnection();
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string name = cbx_product_name.Text;
            if (db.deleteProduct(name))
            {
                MessageBox.Show("Hoàn tất", "Xóa sản phẩm:" + name, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
                MessageBox.Show("Thất bại", "Xóa không thành công",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            SqlConnection cnt = db.getConnection();
            try
            {
                cnt.Open();
                string query = "SELECT name_product FROM products";
                SqlCommand cmd = new SqlCommand(query, cnt);
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read()) 
                {
                    cbx_product_name.Items.Add(data["name_product"]);
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
            cbx_product_name.SelectedIndex = 0;
        }
    }
}
