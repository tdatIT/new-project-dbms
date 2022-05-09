
namespace FINAL_PROJECT_DBMS.View
{
    partial class Analystic_Revenue_In_Day
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.create_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(106, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOANH THU CỦA QUÁN TRONG NGÀY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập năm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(394, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(260, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập tháng";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(657, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(527, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập ngày";
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_enter.Location = new System.Drawing.Point(330, 159);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(123, 40);
            this.btn_enter.TabIndex = 7;
            this.btn_enter.Text = "ENTER";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_result);
            this.panel1.Location = new System.Drawing.Point(2, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 412);
            this.panel1.TabIndex = 9;
            // 
            // dgv_result
            // 
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.create_day});
            this.dgv_result.Location = new System.Drawing.Point(11, 15);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.RowHeadersWidth = 51;
            this.dgv_result.Size = new System.Drawing.Size(776, 382);
            this.dgv_result.TabIndex = 9;
            // 
            // create_day
            // 
            this.create_day.DataPropertyName = "create_day";
            this.create_day.HeaderText = "Ngày tạo đơn";
            this.create_day.MinimumWidth = 6;
            this.create_day.Name = "create_day";
            this.create_day.Width = 300;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(136)))), ((int)(((byte)(230)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(40, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kết quả";
            // 
            // Analystic_Revenue_In_Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(136)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Analystic_Revenue_In_Day";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analystic_Revenue_In_Day";
            this.Load += new System.EventHandler(this.Analystic_Revenue_In_Day_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_day;
    }
}