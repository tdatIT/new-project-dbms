using FINAL_PROJECT_DBMS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT_DBMS
{
    public partial class Form1 : Form
    {
        private Button currentBtn;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }
        private void disableButton()
        {
            foreach(Control prevBtn in pn_menu.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.MediumAquamarine;
                    prevBtn.ForeColor = Color.Black;
                }
            }
        }
        private void activeButton(Object btnSender)
        {
            if (btnSender != null)
            {
                if(currentBtn != (Button)btnSender)
                {
                    disableButton();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.FromArgb(16, 65, 39);
                    currentBtn.ForeColor = Color.White;
                }
            }
        }
        private void openChildForm(Form childForm,object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pn_child.Controls.Add(childForm);
            this.pn_child.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            activeButton(sender);
            lb_chucnang.Text = "CHỨC NĂNG THÊM MỚI";
            openChildForm(new AddForm(), sender);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            activeButton(sender);
            lb_chucnang.Text = "CHỨC NĂNG XÓA";
            openChildForm(new DelForm(), sender);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            activeButton(sender);
            lb_chucnang.Text = "CHỨC NĂNG SỬA ĐỔI";
            openChildForm(new UpdateForm(), sender);
        }

        private void btn_analyst_Click(object sender, EventArgs e)
        {
            activeButton(sender);
            lb_chucnang.Text = "CHỨC NĂNG PHÂN TÍCH DỮ LIỆU";
            openChildForm(new AnalyticsForm(), sender);
        }

        private void pn_title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
