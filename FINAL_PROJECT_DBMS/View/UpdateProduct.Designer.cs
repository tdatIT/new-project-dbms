namespace FINAL_PROJECT_DBMS.View
{
    partial class UpdateProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_info = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pn_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(193, 72);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(137, 26);
            this.txt_id.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(165, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pn_info
            // 
            this.pn_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_info.Controls.Add(this.button2);
            this.pn_info.Controls.Add(this.cbx_type);
            this.pn_info.Controls.Add(this.label6);
            this.pn_info.Controls.Add(this.txt_cost);
            this.pn_info.Controls.Add(this.label5);
            this.pn_info.Controls.Add(this.txt_price);
            this.pn_info.Controls.Add(this.label4);
            this.pn_info.Controls.Add(this.txt_name);
            this.pn_info.Controls.Add(this.label3);
            this.pn_info.Enabled = false;
            this.pn_info.Location = new System.Drawing.Point(51, 165);
            this.pn_info.Name = "pn_info";
            this.pn_info.Size = new System.Drawing.Size(299, 297);
            this.pn_info.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(112, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbx_type
            // 
            this.cbx_type.Enabled = false;
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Items.AddRange(new object[] {
            "DRINK",
            "FOOD",
            "CAKE"});
            this.cbx_type.Location = new System.Drawing.Point(130, 201);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(94, 27);
            this.cbx_type.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Loại";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(130, 137);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(137, 26);
            this.txt_cost.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Chi phí";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(130, 80);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(137, 26);
            this.txt_price.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá";
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(130, 24);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(137, 26);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "CẬP NHẬT SẢN PHẨM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Thông tin";
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 497);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pn_info);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateRole";
            this.pn_info.ResumeLayout(false);
            this.pn_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pn_info;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}