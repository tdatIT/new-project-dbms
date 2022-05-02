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
    public partial class DeleteBranch : Form
    {
        private DAOConnection db2;
        public DeleteBranch()
        {
            db2 = new DAOConnection();
            InitializeComponent();
        }

        private void DeleteBranch_Load(object sender, EventArgs e)
        {
            SqlConnection cnt = db2.getConnection();
            try
            {
                cnt.Open();
                string query = "SELECT shop_ID FROM SHOP";
                SqlCommand cmd = new SqlCommand(query, cnt);
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cbx_delete_branch.Items.Add(data["shop_ID"]);
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
        }

       

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string name = cbx_delete_branch.Text;
            if (db2.deleteEmployee(name))
            {
                MessageBox.Show("Hoàn tất", "Xóa chi nhánh:" + name,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
                MessageBox.Show("Thất bại", "Xóa không thành công:" + name,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
