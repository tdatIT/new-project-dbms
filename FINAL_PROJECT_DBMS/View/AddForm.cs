using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT_DBMS.View
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_NewEmp newAddEmp = new Add_NewEmp();
            newAddEmp.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewOrder orderForm = new AddNewOrder();
            orderForm.Visible = true;
           
        }
 

     

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AddcCustomer customerForm = new AddcCustomer();
            customerForm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewVoucher Voucherform = new AddNewVoucher();
            Voucherform.Visible = true;
        }
    }
}
