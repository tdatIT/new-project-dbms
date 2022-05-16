namespace FINAL_PROJECT_DBMS.View
{
    partial class AddNewOrder
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
            this.pn_order = new System.Windows.Forms.Panel();
            this.cbx_shop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_c_phone = new System.Windows.Forms.TextBox();
            this.pn_payment = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_payment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.cbx_voucher = new System.Windows.Forms.ComboBox();
            this.cbx_payment_method = new System.Windows.Forms.ComboBox();
            this.pn_product = new System.Windows.Forms.Panel();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_order_product = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pn_order.SuspendLayout();
            this.pn_payment.SuspendLayout();
            this.pn_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_product)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_order
            // 
            this.pn_order.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_order.Controls.Add(this.cbx_shop);
            this.pn_order.Controls.Add(this.label9);
            this.pn_order.Controls.Add(this.btn_order);
            this.pn_order.Controls.Add(this.txt_year);
            this.pn_order.Controls.Add(this.txt_month);
            this.pn_order.Controls.Add(this.txt_day);
            this.pn_order.Controls.Add(this.lb);
            this.pn_order.Controls.Add(this.label1);
            this.pn_order.Controls.Add(this.txt_c_phone);
            this.pn_order.Location = new System.Drawing.Point(42, 36);
            this.pn_order.Name = "pn_order";
            this.pn_order.Size = new System.Drawing.Size(258, 180);
            this.pn_order.TabIndex = 0;
            this.pn_order.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_order_Paint);
            // 
            // cbx_shop
            // 
            this.cbx_shop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_shop.FormattingEnabled = true;
            this.cbx_shop.Location = new System.Drawing.Point(120, 101);
            this.cbx_shop.Name = "cbx_shop";
            this.cbx_shop.Size = new System.Drawing.Size(85, 23);
            this.cbx_shop.TabIndex = 9;
            this.cbx_shop.SelectedIndexChanged += new System.EventHandler(this.cbx_shop_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "SHOP";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(17, 133);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(99, 27);
            this.btn_order.TabIndex = 7;
            this.btn_order.Text = "Tạo đơn hàng";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(183, 64);
            this.txt_year.Name = "txt_year";
            this.txt_year.ReadOnly = true;
            this.txt_year.Size = new System.Drawing.Size(59, 23);
            this.txt_year.TabIndex = 5;
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(138, 64);
            this.txt_month.Name = "txt_month";
            this.txt_month.ReadOnly = true;
            this.txt_month.Size = new System.Drawing.Size(33, 23);
            this.txt_month.TabIndex = 4;
            // 
            // txt_day
            // 
            this.txt_day.Location = new System.Drawing.Point(85, 64);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(35, 23);
            this.txt_day.TabIndex = 3;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(14, 64);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(34, 15);
            this.lb.TabIndex = 2;
            this.lb.Text = "DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số ĐT";
            // 
            // txt_c_phone
            // 
            this.txt_c_phone.Location = new System.Drawing.Point(85, 25);
            this.txt_c_phone.Name = "txt_c_phone";
            this.txt_c_phone.Size = new System.Drawing.Size(157, 23);
            this.txt_c_phone.TabIndex = 0;
            // 
            // pn_payment
            // 
            this.pn_payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_payment.Controls.Add(this.label5);
            this.pn_payment.Controls.Add(this.btn_payment);
            this.pn_payment.Controls.Add(this.label4);
            this.pn_payment.Controls.Add(this.label3);
            this.pn_payment.Controls.Add(this.label2);
            this.pn_payment.Controls.Add(this.txt_totalprice);
            this.pn_payment.Controls.Add(this.cbx_voucher);
            this.pn_payment.Controls.Add(this.cbx_payment_method);
            this.pn_payment.Enabled = false;
            this.pn_payment.Location = new System.Drawing.Point(352, 36);
            this.pn_payment.Name = "pn_payment";
            this.pn_payment.Size = new System.Drawing.Size(334, 180);
            this.pn_payment.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "VND";
            // 
            // btn_payment
            // 
            this.btn_payment.Location = new System.Drawing.Point(220, 133);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(99, 32);
            this.btn_payment.TabIndex = 6;
            this.btn_payment.Text = "Thanh toán";
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thành tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Voucher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phương thức TT";
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.Location = new System.Drawing.Point(121, 100);
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.ReadOnly = true;
            this.txt_totalprice.Size = new System.Drawing.Size(111, 23);
            this.txt_totalprice.TabIndex = 2;
            // 
            // cbx_voucher
            // 
            this.cbx_voucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_voucher.FormattingEnabled = true;
            this.cbx_voucher.Location = new System.Drawing.Point(121, 60);
            this.cbx_voucher.Name = "cbx_voucher";
            this.cbx_voucher.Size = new System.Drawing.Size(182, 23);
            this.cbx_voucher.TabIndex = 1;
            // 
            // cbx_payment_method
            // 
            this.cbx_payment_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_payment_method.FormattingEnabled = true;
            this.cbx_payment_method.Items.AddRange(new object[] {
            "Trực tiếp",
            "Momo",
            "Giao hàng"});
            this.cbx_payment_method.Location = new System.Drawing.Point(121, 22);
            this.cbx_payment_method.Name = "cbx_payment_method";
            this.cbx_payment_method.Size = new System.Drawing.Size(182, 23);
            this.cbx_payment_method.TabIndex = 0;
            // 
            // pn_product
            // 
            this.pn_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_product.Controls.Add(this.btn_add_product);
            this.pn_product.Controls.Add(this.txt_amount);
            this.pn_product.Controls.Add(this.dgv_menu);
            this.pn_product.Controls.Add(this.panel4);
            this.pn_product.Enabled = false;
            this.pn_product.Location = new System.Drawing.Point(42, 241);
            this.pn_product.Name = "pn_product";
            this.pn_product.Size = new System.Drawing.Size(644, 240);
            this.pn_product.TabIndex = 2;
            // 
            // btn_add_product
            // 
            this.btn_add_product.Location = new System.Drawing.Point(143, 208);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(99, 27);
            this.btn_add_product.TabIndex = 2;
            this.btn_add_product.Text = "Thêm món";
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(70, 210);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(42, 23);
            this.txt_amount.TabIndex = 1;
            this.txt_amount.Text = "1";
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgv_menu
            // 
            this.dgv_menu.AllowUserToAddRows = false;
            this.dgv_menu.AllowUserToDeleteRows = false;
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.name_product,
            this.cost});
            this.dgv_menu.Location = new System.Drawing.Point(17, 23);
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.ReadOnly = true;
            this.dgv_menu.RowHeadersWidth = 51;
            this.dgv_menu.Size = new System.Drawing.Size(307, 181);
            this.dgv_menu.TabIndex = 2;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.Frozen = true;
            this.product_id.HeaderText = "Mã";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Width = 40;
            // 
            // name_product
            // 
            this.name_product.DataPropertyName = "name_product";
            this.name_product.HeaderText = "Tên món";
            this.name_product.MinimumWidth = 6;
            this.name_product.Name = "name_product";
            this.name_product.ReadOnly = true;
            this.name_product.Width = 180;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Giá";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 50;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgv_order_product);
            this.panel4.Location = new System.Drawing.Point(350, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 191);
            this.panel4.TabIndex = 1;
            // 
            // dgv_order_product
            // 
            this.dgv_order_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order_product.Location = new System.Drawing.Point(15, 14);
            this.dgv_order_product.Name = "dgv_order_product";
            this.dgv_order_product.RowHeadersWidth = 51;
            this.dgv_order_product.Size = new System.Drawing.Size(259, 164);
            this.dgv_order_product.TabIndex = 0;
            this.dgv_order_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_product_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "DANH SÁCH MÓN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "TẠO ĐƠN HÀNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "THANH TOÁN";
            // 
            // AddNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 516);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pn_product);
            this.Controls.Add(this.pn_payment);
            this.Controls.Add(this.pn_order);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewOrder";
            this.Load += new System.EventHandler(this.AddNewOrder_Load);
            this.pn_order.ResumeLayout(false);
            this.pn_order.PerformLayout();
            this.pn_payment.ResumeLayout(false);
            this.pn_payment.PerformLayout();
            this.pn_product.ResumeLayout(false);
            this.pn_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_order;
        private System.Windows.Forms.Panel pn_payment;
        private System.Windows.Forms.Panel pn_product;
        private System.Windows.Forms.TextBox txt_c_phone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.DataGridView dgv_order_product;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.ComboBox cbx_voucher;
        private System.Windows.Forms.ComboBox cbx_payment_method;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_shop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
    }
}