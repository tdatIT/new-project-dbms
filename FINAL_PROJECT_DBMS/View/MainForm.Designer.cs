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
            this.pn_title = new System.Windows.Forms.Panel();
            this.lb_chucnang = new System.Windows.Forms.Label();
            this.lbHello = new System.Windows.Forms.Label();
            this.pn_child = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_analyst = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pn_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.MediumAquamarine;
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
            this.lb_chucnang.Location = new System.Drawing.Point(6, 21);
            this.lb_chucnang.Name = "lb_chucnang";
            this.lb_chucnang.Size = new System.Drawing.Size(69, 25);
            this.lb_chucnang.TabIndex = 0;
            this.lb_chucnang.Text = "HOME";
            this.lb_chucnang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_chucnang.Click += new System.EventHandler(this.label1_Click);
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
            // pn_child
            // 
            this.pn_child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_child.Location = new System.Drawing.Point(180, 64);
            this.pn_child.Name = "pn_child";
            this.pn_child.Size = new System.Drawing.Size(704, 547);
            this.pn_child.TabIndex = 2;
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
            this.btn_analyst.FlatAppearance.BorderSize = 0;
            this.btn_analyst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_analyst.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_analyst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_analyst.Image = ((System.Drawing.Image)(resources.GetObject("btn_analyst.Image")));
            this.btn_analyst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_analyst.Location = new System.Drawing.Point(0, 214);
            this.btn_analyst.Name = "btn_analyst";
            this.btn_analyst.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_analyst.Size = new System.Drawing.Size(180, 50);
            this.btn_analyst.TabIndex = 4;
            this.btn_analyst.Text = "Phân Tích";
            this.btn_analyst.UseVisualStyleBackColor = true;
            this.btn_analyst.Click += new System.EventHandler(this.btn_analyst_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(0, 164);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_edit.Size = new System.Drawing.Size(180, 50);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_del.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_del.Location = new System.Drawing.Point(0, 114);
            this.btn_del.Name = "btn_del";
            this.btn_del.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_del.Size = new System.Drawing.Size(180, 50);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(0, 64);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_add.Size = new System.Drawing.Size(180, 50);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Thêm";
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
            this.Text = "QUẢN LÝ HỆ THỐNG CỬA HÀNG";
            this.pn_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_title.ResumeLayout(false);
            this.pn_title.PerformLayout();
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
    }
}

