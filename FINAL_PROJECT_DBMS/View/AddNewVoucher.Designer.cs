
namespace FINAL_PROJECT_DBMS.View
{
    partial class AddNewVoucher
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
            this.txt_contraint = new System.Windows.Forms.ComboBox();
            this.End_Year = new System.Windows.Forms.TextBox();
            this.End_Month = new System.Windows.Forms.TextBox();
            this.End_Day = new System.Windows.Forms.TextBox();
            this.start_year = new System.Windows.Forms.TextBox();
            this.start_month = new System.Windows.Forms.TextBox();
            this.start_day = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtVoucherId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Giá trị";
            // 
            // txt_contraint
            // 
            this.txt_contraint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_contraint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraint.FormattingEnabled = true;
            this.txt_contraint.Items.AddRange(new object[] {
            "BRONZE",
            "SIVER",
            "GOLD"});
            this.txt_contraint.Location = new System.Drawing.Point(232, 281);
            this.txt_contraint.Name = "txt_contraint";
            this.txt_contraint.Size = new System.Drawing.Size(141, 31);
            this.txt_contraint.TabIndex = 18;
            // 
            // End_Year
            // 
            this.End_Year.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_Year.Location = new System.Drawing.Point(314, 221);
            this.End_Year.Name = "End_Year";
            this.End_Year.Size = new System.Drawing.Size(59, 30);
            this.End_Year.TabIndex = 16;
            // 
            // End_Month
            // 
            this.End_Month.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_Month.Location = new System.Drawing.Point(280, 221);
            this.End_Month.Name = "End_Month";
            this.End_Month.Size = new System.Drawing.Size(28, 30);
            this.End_Month.TabIndex = 15;
            // 
            // End_Day
            // 
            this.End_Day.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_Day.Location = new System.Drawing.Point(232, 221);
            this.End_Day.Name = "End_Day";
            this.End_Day.Size = new System.Drawing.Size(39, 30);
            this.End_Day.TabIndex = 14;
            // 
            // start_year
            // 
            this.start_year.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_year.Location = new System.Drawing.Point(314, 166);
            this.start_year.Name = "start_year";
            this.start_year.Size = new System.Drawing.Size(59, 30);
            this.start_year.TabIndex = 13;
            // 
            // start_month
            // 
            this.start_month.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_month.Location = new System.Drawing.Point(277, 166);
            this.start_month.Name = "start_month";
            this.start_month.Size = new System.Drawing.Size(31, 30);
            this.start_month.TabIndex = 12;
            // 
            // start_day
            // 
            this.start_day.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_day.Location = new System.Drawing.Point(232, 166);
            this.start_day.Name = "start_day";
            this.start_day.Size = new System.Drawing.Size(39, 30);
            this.start_day.TabIndex = 11;
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(232, 114);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(141, 30);
            this.txtDes.TabIndex = 10;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(232, 62);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(141, 30);
            this.txtDiscount.TabIndex = 9;
            // 
            // txtVoucherId
            // 
            this.txtVoucherId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherId.Location = new System.Drawing.Point(232, 12);
            this.txtVoucherId.Name = "txtVoucherId";
            this.txtVoucherId.Size = new System.Drawing.Size(141, 30);
            this.txtVoucherId.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Voucher_constraint";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "End day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Start day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voucher ID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_contraint);
            this.panel1.Controls.Add(this.End_Year);
            this.panel1.Controls.Add(this.End_Month);
            this.panel1.Controls.Add(this.End_Day);
            this.panel1.Controls.Add(this.start_year);
            this.panel1.Controls.Add(this.start_month);
            this.panel1.Controls.Add(this.start_day);
            this.panel1.Controls.Add(this.txtDes);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.txtVoucherId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(64, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 342);
            this.panel1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(163, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 45);
            this.label9.TabIndex = 23;
            this.label9.Text = "Thêm Voucher";
            // 
            // AddNewVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Name = "AddNewVoucher";
            this.Text = "AddNewVoucher";
            this.Load += new System.EventHandler(this.AddNewVoucher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_contraint;
        private System.Windows.Forms.TextBox End_Year;
        private System.Windows.Forms.TextBox End_Month;
        private System.Windows.Forms.TextBox End_Day;
        private System.Windows.Forms.TextBox start_year;
        private System.Windows.Forms.TextBox start_month;
        private System.Windows.Forms.TextBox start_day;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtVoucherId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}