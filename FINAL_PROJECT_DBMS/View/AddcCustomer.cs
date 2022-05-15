using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FINAL_PROJECT_DBMS.Model;
namespace FINAL_PROJECT_DBMS
{
    public partial class AddcCustomer : Form
    {

        private DAOConnection cnt = null;
        public AddcCustomer()
        {
            InitializeComponent();
            cnt = new DAOConnection();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            string c_Phone = txtPhone.Text;
            string Address = txtAdd.Text;
            string birthday = txtYear.Text + "-" + txtMonth.Text + "-" + txtDay.Text;
            string Type = cbKhach.Text;
            if (cnt.addNewCustomer(c_Phone, birthday, Address, Type))
            {
                MessageBox.Show("Đăng ký khách thành công",
                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }

        }

        private void AddcCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
