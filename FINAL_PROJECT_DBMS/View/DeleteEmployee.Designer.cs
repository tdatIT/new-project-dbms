
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
            this.btn_Delete_Employee = new System.Windows.Forms.Button();
            this.cbx_Delete_Employee = new System.Windows.Forms.ComboBox();
            this.lb_DelEmp = new System.Windows.Forms.Label();
            this.pn_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_1
            // 
            this.pn_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_1.Controls.Add(this.btn_Delete_Employee);
            this.pn_1.Controls.Add(this.cbx_Delete_Employee);
            this.pn_1.Controls.Add(this.lb_DelEmp);
            this.pn_1.Location = new System.Drawing.Point(27, 17);
            this.pn_1.Name = "pn_1";
            this.pn_1.Size = new System.Drawing.Size(565, 154);
            this.pn_1.TabIndex = 0;
            // 
            // btn_Delete_Employee
            // 
            this.btn_Delete_Employee.Location = new System.Drawing.Point(203, 105);
            this.btn_Delete_Employee.Name = "btn_Delete_Employee";
            this.btn_Delete_Employee.Size = new System.Drawing.Size(122, 30);
            this.btn_Delete_Employee.TabIndex = 5;
            this.btn_Delete_Employee.Text = "Xóa";
            this.btn_Delete_Employee.UseVisualStyleBackColor = true;
            this.btn_Delete_Employee.Click += new System.EventHandler(this.btn_Delete_Employee_Click);
            // 
            // cbx_Delete_Employee
            // 
            this.cbx_Delete_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Delete_Employee.FormattingEnabled = true;
            this.cbx_Delete_Employee.Location = new System.Drawing.Point(318, 20);
            this.cbx_Delete_Employee.Name = "cbx_Delete_Employee";
            this.cbx_Delete_Employee.Size = new System.Drawing.Size(223, 31);
            this.cbx_Delete_Employee.TabIndex = 4;
            // 
            // lb_DelEmp
            // 
            this.lb_DelEmp.AutoSize = true;
            this.lb_DelEmp.Location = new System.Drawing.Point(17, 23);
            this.lb_DelEmp.Name = "lb_DelEmp";
            this.lb_DelEmp.Size = new System.Drawing.Size(229, 23);
            this.lb_DelEmp.TabIndex = 3;
            this.lb_DelEmp.Text = "Chọn tên nhân viên cần xóa:";
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 183);
            this.Controls.Add(this.pn_1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa nhân viên";
            this.Load += new System.EventHandler(this.DeleteEmployee_Load);
            this.pn_1.ResumeLayout(false);
            this.pn_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_1;
        private System.Windows.Forms.Button btn_Delete_Employee;
        private System.Windows.Forms.ComboBox cbx_Delete_Employee;
        private System.Windows.Forms.Label lb_DelEmp;
    }
}