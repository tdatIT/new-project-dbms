﻿namespace FINAL_PROJECT_DBMS.View
{
    partial class Analystic_1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.shop_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month_in_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_delta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_result);
            this.panel1.Location = new System.Drawing.Point(112, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 405);
            this.panel1.TabIndex = 0;
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            this.dgv_result.AllowUserToDeleteRows = false;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shop_id,
            this.month_in_year,
            this.total,
            this.cost_delta,
            this.Message});
            this.dgv_result.Location = new System.Drawing.Point(13, 18);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.ReadOnly = true;
            this.dgv_result.RowHeadersWidth = 51;
            this.dgv_result.Size = new System.Drawing.Size(643, 365);
            this.dgv_result.TabIndex = 0;
            // 
            // shop_id
            // 
            this.shop_id.DataPropertyName = "shop_id";
            this.shop_id.Frozen = true;
            this.shop_id.HeaderText = "SHOP ID";
            this.shop_id.MinimumWidth = 6;
            this.shop_id.Name = "shop_id";
            this.shop_id.ReadOnly = true;
            this.shop_id.Width = 60;
            // 
            // month_in_year
            // 
            this.month_in_year.DataPropertyName = "month_in_year";
            this.month_in_year.HeaderText = "Tháng";
            this.month_in_year.MinimumWidth = 6;
            this.month_in_year.Name = "month_in_year";
            this.month_in_year.ReadOnly = true;
            this.month_in_year.Width = 50;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Tổng chi phí";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 125;
            // 
            // cost_delta
            // 
            this.cost_delta.DataPropertyName = "cost_delta";
            this.cost_delta.HeaderText = "Chênh lệch";
            this.cost_delta.MinimumWidth = 6;
            this.cost_delta.Name = "cost_delta";
            this.cost_delta.ReadOnly = true;
            this.cost_delta.Width = 125;
            // 
            // Message
            // 
            this.Message.DataPropertyName = "Message";
            this.Message.HeaderText = "Kết luận";
            this.Message.MinimumWidth = 6;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(203, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập vào [SHOP ID]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(388, 128);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(109, 30);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "ENTER";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(172, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "CHÊNH LỆCH CHI PHÍ DUY TRÌ HÀNG THÁNG CỦA SHOP";
            // 
            // Analystic_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(136)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Analystic_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân tích";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn shop_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn month_in_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost_delta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
    }
}