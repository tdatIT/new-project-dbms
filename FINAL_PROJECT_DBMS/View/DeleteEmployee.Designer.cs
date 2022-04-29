
namespace FINAL_PROJECT_DBMS.View
{
    partial class DeleteEmployee
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
            this.pn_1 = new System.Windows.Forms.Panel();
            this.btn_xoa = new System.Windows.Forms.TextBox();
            this.cbx_employee_name = new System.Windows.Forms.ComboBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.pn_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_1
            // 
            this.pn_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_1.Controls.Add(this.btn_xoa);
            this.pn_1.Controls.Add(this.cbx_employee_name);
            this.pn_1.Controls.Add(this.lb_1);
            this.pn_1.Location = new System.Drawing.Point(14, 15);
            this.pn_1.Name = "pn_1";
            this.pn_1.Size = new System.Drawing.Size(614, 180);
            this.pn_1.TabIndex = 0;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.Location = new System.Drawing.Point(244, 110);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 30);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xoa.TextChanged += new System.EventHandler(this.btn_xoa_TextChanged);
            // 
            // cbx_employee_name
            // 
            this.cbx_employee_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_employee_name.FormattingEnabled = true;
            this.cbx_employee_name.Location = new System.Drawing.Point(338, 33);
            this.cbx_employee_name.Name = "cbx_employee_name";
            this.cbx_employee_name.Size = new System.Drawing.Size(258, 24);
            this.cbx_employee_name.TabIndex = 4;
            this.cbx_employee_name.SelectedIndexChanged += new System.EventHandler(this.cbx_employee_name_SelectedIndexChanged);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_1.Location = new System.Drawing.Point(20, 34);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(225, 23);
            this.lb_1.TabIndex = 3;
            this.lb_1.Text = "Chọn tên nhân viên cần xóa";
            this.lb_1.Click += new System.EventHandler(this.lb_1_Click);
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 211);
            this.Controls.Add(this.pn_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa nhân viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pn_1.ResumeLayout(false);
            this.pn_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_1;
        private System.Windows.Forms.TextBox btn_xoa;
        private System.Windows.Forms.ComboBox cbx_employee_name;
        private System.Windows.Forms.Label lb_1;
    }
}