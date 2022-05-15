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
            this.cbx_func = new System.Windows.Forms.ComboBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_result
            // 
            this.pn_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_result.Controls.Add(this.dgv_result);
            this.pn_result.Location = new System.Drawing.Point(108, 225);
            this.pn_result.Name = "pn_result";
            this.pn_result.Size = new System.Drawing.Size(789, 437);
            this.pn_result.TabIndex = 0;
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            this.dgv_result.AllowUserToDeleteRows = false;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(25, 18);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.ReadOnly = true;
            this.dgv_result.RowHeadersWidth = 51;
            this.dgv_result.Size = new System.Drawing.Size(733, 379);
            this.dgv_result.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(77, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chức năng thực hiện";
            // 
            // cbx_func
            // 
            this.cbx_func.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_func.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_func.FormattingEnabled = true;
            this.cbx_func.Items.AddRange(new object[] {
            "NV có kinh nghiệm làm việc( từ 2 tháng đến 3 tháng)",
            "Danh sách đơn hàng chưa thanh toán",
            "In ra 5 sản phẩm bán chạy nhất",
            "Phân tích chênh lệch phí duy trì cửa hàng",
            "Xem doanh thu, lợi nhuận của cửa hàng",
            "Thống kê voucher được sử dụng trong tháng",
            "Tổng chi phí 3 tháng gần nhất",
            "Voucher có thể sử dụng trong ngày",
            "Những chuỗi chi nhánh ở TP.HCM",
            "Xem số tiền khách hàng thanh toán",
            "Sản phẩm bán chạy của từng cửa hàng",
            "Doanh thu trong ngày",
            "Sản phẩm đã bán trong ngày"});
            this.cbx_func.Location = new System.Drawing.Point(284, 66);
            this.cbx_func.Name = "cbx_func";
            this.cbx_func.Size = new System.Drawing.Size(490, 29);
            this.cbx_func.TabIndex = 3;
            this.cbx_func.SelectedIndexChanged += new System.EventHandler(this.cbx_func_SelectedIndexChanged);
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Enter.Location = new System.Drawing.Point(409, 177);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(213, 39);
            this.btn_Enter.TabIndex = 4;
            this.btn_Enter.Text = "ENTER";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(383, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "PHÂN TÍCH DỮ LIỆU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(171, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "KẾT QUẢ";
            // 
            // AnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(136)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1038, 704);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.cbx_func);
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
        private System.Windows.Forms.ComboBox cbx_func;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
    }
}