namespace FINAL_PROJECT_DBMS.View
{
    partial class AnalyticsForm
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
            this.pn_result = new System.Windows.Forms.Panel();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_func = new System.Windows.Forms.ComboBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_result
            // 
            this.pn_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_result.Controls.Add(this.dgv_result);
            this.pn_result.Location = new System.Drawing.Point(47, 153);
            this.pn_result.Name = "pn_result";
            this.pn_result.Size = new System.Drawing.Size(586, 254);
            this.pn_result.TabIndex = 0;
            // 
            // dgv_result
            // 
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(13, 17);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.RowHeadersWidth = 51;
            this.dgv_result.Size = new System.Drawing.Size(553, 224);
            this.dgv_result.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(130, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chức năng thực hiện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(97, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "KẾT QUẢ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbx_func
            // 
            this.cbx_func.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_func.FormattingEnabled = true;
            this.cbx_func.Items.AddRange(new object[] {
            "NV có kinh nghiệm làm việc( từ 2 tháng đến 3 tháng)",
            "Danh sách đơn hàng chưa thanh toán",
            "In ra 5 sản phẩm bán chạy nhất",
            "Phân tích chênh lệch phí duy trì cửa hàng",
            "Xem doanh thu, lợi nhuận của cửa hàng",
            "Tổng chi phí 3 tháng gần nhất",
            "Voucher có thể sử dụng trong ngày",
            "Những chuỗi chi nhánh ở TP.HCM",
            "Xem số tiền khách hàng thanh toán",
            "Sản phẩm bán chạy của từng cửa hàng"});
            this.cbx_func.Location = new System.Drawing.Point(284, 65);
            this.cbx_func.Name = "cbx_func";
            this.cbx_func.Size = new System.Drawing.Size(267, 27);
            this.cbx_func.TabIndex = 3;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Enter.Location = new System.Drawing.Point(284, 108);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(109, 26);
            this.btn_Enter.TabIndex = 4;
            this.btn_Enter.Text = "ENTER";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(258, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "PHÂN TÍCH DỮ LIỆU";
            // 
            // AnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(136)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(674, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.cbx_func);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn_result);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AnalyticsForm";
            this.Text = "Analytics";
            this.Load += new System.EventHandler(this.AnalyticsForm_Load);
            this.pn_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_func;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label label3;
    }
}