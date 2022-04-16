namespace FINAL_PROJECT_DBMS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pn_menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHello = new System.Windows.Forms.Label();
            this.pn_title = new System.Windows.Forms.Panel();
            this.lb_chucnang = new System.Windows.Forms.Label();
            this.pn_child = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lb_notify = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_analyst = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pn_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn_title.SuspendLayout();
            this.pn_child.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pn_menu.Controls.Add(this.btn_home);
            this.pn_menu.Controls.Add(this.btn_info);
            this.pn_menu.Controls.Add(this.btn_analyst);
            this.pn_menu.Controls.Add(this.btn_edit);
            this.pn_menu.Controls.Add(this.btn_del);
            this.pn_menu.Controls.Add(this.btn_add);
            this.pn_menu.Controls.Add(this.panel1);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.Location = new System.Drawing.Point(0, 0);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(180, 611);
            this.pn_menu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.lbHello);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 64);
            this.panel1.TabIndex = 0;
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbHello.Location = new System.Drawing.Point(59, 9);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(62, 17);
            this.lbHello.TabIndex = 1;
            this.lbHello.Text = "Xin Chào";
            this.lbHello.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pn_title
            // 
            this.pn_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(65)))), ((int)(((byte)(39)))));
            this.pn_title.Controls.Add(this.pictureBox1);
            this.pn_title.Controls.Add(this.lb_chucnang);
            this.pn_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_title.Location = new System.Drawing.Point(180, 0);
            this.pn_title.Name = "pn_title";
            this.pn_title.Size = new System.Drawing.Size(704, 64);
            this.pn_title.TabIndex = 1;
            this.pn_title.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_title_Paint);
            // 
            // lb_chucnang
            // 
            this.lb_chucnang.AutoSize = true;
            this.lb_chucnang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chucnang.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_chucnang.Location = new System.Drawing.Point(30, 20);
            this.lb_chucnang.Name = "lb_chucnang";
            this.lb_chucnang.Size = new System.Drawing.Size(71, 25);
            this.lb_chucnang.TabIndex = 0;
            this.lb_chucnang.Text = "LOGIN";
            this.lb_chucnang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_chucnang.Click += new System.EventHandler(this.label1_Click);
            // 
            // pn_child
            // 
            this.pn_child.Controls.Add(this.pictureBox2);
            this.pn_child.Controls.Add(this.btn_logout);
            this.pn_child.Controls.Add(this.lb_notify);
            this.pn_child.Controls.Add(this.label3);
            this.pn_child.Controls.Add(this.groupBox1);
            this.pn_child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_child.Location = new System.Drawing.Point(180, 64);
            this.pn_child.Name = "pn_child";
            this.pn_child.Size = new System.Drawing.Size(704, 547);
            this.pn_child.TabIndex = 2;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(588, 64);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(82, 33);
            this.btn_logout.TabIndex = 14;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // lb_notify
            // 
            this.lb_notify.AutoSize = true;
            this.lb_notify.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_notify.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_notify.Location = new System.Drawing.Point(271, 170);
            this.lb_notify.Name = "lb_notify";
            this.lb_notify.Size = new System.Drawing.Size(167, 24);
            this.lb_notify.TabIndex = 13;
            this.lb_notify.Text = "Vui lòng đăng nhập ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Be Vietnam Pro Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(229, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "CÔNG TY DBZ MILKTEA ®";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(184, 234);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(335, 200);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐĂNG NHẬP";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(91, 85);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(218, 25);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Lime;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(118, 134);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(118, 30);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(91, 50);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(218, 25);
            this.txt_username.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::FINAL_PROJECT_DBMS.Properties.Resources.boba_drink_bubble_tea_tea_cup_glass_icon_208001;
            this.pictureBox1.Location = new System.Drawing.Point(638, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.Enabled = false;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 264);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(180, 50);
            this.btn_home.TabIndex = 6;
            this.btn_home.Text = "TRANG CHỦ";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.btn_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_info.FlatAppearance.BorderSize = 2;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_info.Image = global::FINAL_PROJECT_DBMS.Properties.Resources.inform_info_answer_support_faq_communication_information_icon_219306;
            this.btn_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_info.Location = new System.Drawing.Point(0, 538);
            this.btn_info.Name = "btn_info";
            this.btn_info.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_info.Size = new System.Drawing.Size(180, 73);
            this.btn_info.TabIndex = 5;
            this.btn_info.Text = "Thông tin";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_analyst
            // 
            this.btn_analyst.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_analyst.Enabled = false;
            this.btn_analyst.FlatAppearance.BorderSize = 0;
            this.btn_analyst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_analyst.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analyst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_analyst.Image = ((System.Drawing.Image)(resources.GetObject("btn_analyst.Image")));
            this.btn_analyst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_analyst.Location = new System.Drawing.Point(0, 214);
            this.btn_analyst.Name = "btn_analyst";
            this.btn_analyst.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_analyst.Size = new System.Drawing.Size(180, 50);
            this.btn_analyst.TabIndex = 4;
            this.btn_analyst.Text = "PHÂN TÍCH";
            this.btn_analyst.UseVisualStyleBackColor = true;
            this.btn_analyst.Click += new System.EventHandler(this.btn_analyst_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_edit.Enabled = false;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(0, 164);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_edit.Size = new System.Drawing.Size(180, 50);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "SỬA";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_del.Enabled = false;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_del.Location = new System.Drawing.Point(0, 114);
            this.btn_del.Name = "btn_del";
            this.btn_del.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_del.Size = new System.Drawing.Size(180, 50);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "XÓA";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add.Enabled = false;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(0, 64);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_add.Size = new System.Drawing.Size(180, 50);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "THÊM";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.pn_child);
            this.Controls.Add(this.pn_title);
            this.Controls.Add(this.pn_menu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ HỆ THỐNG CỬA HÀNG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pn_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_title.ResumeLayout(false);
            this.pn_title.PerformLayout();
            this.pn_child.ResumeLayout(false);
            this.pn_child.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_analyst;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lb_chucnang;
        private System.Windows.Forms.Label lbHello;
        private System.Windows.Forms.Panel pn_child;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lb_notify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
    }
}

