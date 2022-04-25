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
    public partial class DelForm : Form
    {
        public DelForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteProduct form2 = new DeleteProduct();
            form2.Visible = true;
        }
    }
}
