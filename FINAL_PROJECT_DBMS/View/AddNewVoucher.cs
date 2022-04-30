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

namespace FINAL_PROJECT_DBMS.View
{
    public partial class AddNewVoucher : Form
    {
        private DAOConnection cnt = null;
        public AddNewVoucher()
        {
            InitializeComponent();
            cnt = new DAOConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string VoucherId = txtVoucherId.Text;
            string Discount = txtDiscount.Text;
            string Description = txtDes.Text;
            string date_star = start_year.Text + "-" + start_month.Text + "-" + start_day.Text;
            string date_end = End_Year.Text + "-" + End_Month.Text + "-" + End_Day.Text;
            string constraint = txt_contraint.Text;
            if (cnt.addNewVoucher(VoucherId, Discount, Description, date_star, date_end, constraint))
            {
                MessageBox.Show("Thêm voucher thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void AddNewVoucher_Load(object sender, EventArgs e)
        {

        }
    }
}
