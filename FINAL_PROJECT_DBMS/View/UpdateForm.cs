﻿using System;
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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateRole updateRole = new UpdateRole();
            updateRole.Visible = true;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
