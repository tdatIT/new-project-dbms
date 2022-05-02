
namespace FINAL_PROJECT_DBMS.View
{
    partial class DeleteBranch
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
            this.cbx_delete_branch = new System.Windows.Forms.ComboBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.pn_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_1
            // 
            this.pn_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_1.Controls.Add(this.btn_Xoa);
            this.pn_1.Controls.Add(this.cbx_delete_branch);
            this.pn_1.Controls.Add(this.lb_1);
            this.pn_1.Location = new System.Drawing.Point(23, 13);
            this.pn_1.Name = "pn_1";
            this.pn_1.Size = new System.Drawing.Size(675, 178);
            this.pn_1.TabIndex = 0;
            // 
            // cbx_delete_branch
            // 
            this.cbx_delete_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_delete_branch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbx_delete_branch.FormattingEnabled = true;
            this.cbx_delete_branch.Location = new System.Drawing.Point(383, 26);
            this.cbx_delete_branch.Name = "cbx_delete_branch";
            this.cbx_delete_branch.Size = new System.Drawing.Size(229, 31);
            this.cbx_delete_branch.TabIndex = 4;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_1.Location = new System.Drawing.Point(62, 27);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(188, 23);
            this.lb_1.TabIndex = 3;
            this.lb_1.Text = "Chọn chi nhánh để xóa";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Xoa.Location = new System.Drawing.Point(265, 115);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(107, 43);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // DeleteBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 207);
            this.Controls.Add(this.pn_1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteBranch";
            this.Load += new System.EventHandler(this.DeleteBranch_Load);
            this.pn_1.ResumeLayout(false);
            this.pn_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_1;
        private System.Windows.Forms.ComboBox cbx_delete_branch;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Button btn_Xoa;
    }
}