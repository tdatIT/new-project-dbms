namespace FINAL_PROJECT_DBMS.View
{
    partial class DeleteProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_product_name = new System.Windows.Forms.ComboBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.pn_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_1
            // 
            this.pn_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_1.Controls.Add(this.label1);
            this.pn_1.Controls.Add(this.cbx_product_name);
            this.pn_1.Controls.Add(this.btn_enter);
            this.pn_1.Location = new System.Drawing.Point(35, 30);
            this.pn_1.Name = "pn_1";
            this.pn_1.Size = new System.Drawing.Size(391, 109);
            this.pn_1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn sản phẩm cần xóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbx_product_name
            // 
            this.cbx_product_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_product_name.FormattingEnabled = true;
            this.cbx_product_name.Location = new System.Drawing.Point(166, 14);
            this.cbx_product_name.Name = "cbx_product_name";
            this.cbx_product_name.Size = new System.Drawing.Size(205, 21);
            this.cbx_product_name.TabIndex = 4;
            this.cbx_product_name.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Location = new System.Drawing.Point(140, 58);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(108, 35);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "XÁC NHẬN";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 169);
            this.Controls.Add(this.pn_1);
            this.Name = "DeleteProduct";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DeleteProduct_Load);
            this.pn_1.ResumeLayout(false);
            this.pn_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_product_name;
        private System.Windows.Forms.Button btn_enter;
    }
}