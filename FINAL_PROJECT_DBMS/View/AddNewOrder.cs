﻿using FINAL_PROJECT_DBMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT_DBMS.View
{
    public partial class AddNewOrder : Form
    {
        private DAOConnection sqlDB;
        private int order_id;
        public AddNewOrder()
        {
            sqlDB = new DAOConnection();
            InitializeComponent();
        }

        private void AddNewOrder_Load(object sender, EventArgs e)
        {
            SqlConnection sql = sqlDB.getConnection();
            string query = "SELECT shop_id FROM shop";
            sql.Open();
            SqlCommand cmd = new SqlCommand(query,sql);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cbx_shop.Items.Add(rd["shop_id"]);
            }
            txt_day.Text = DateTime.Now.Day.ToString();
            txt_month.Text = DateTime.Now.Month.ToString();
            txt_year.Text = DateTime.Now.Year.ToString();
            cbx_shop.SelectedIndex = 0;
        }

        private void cbx_shop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            string c_phone = txt_c_phone.Text;
            string create_date = txt_year.Text + "-" + txt_month.Text + "-" + txt_day.Text;
            string shop_id = cbx_shop.Text;
            if (sqlDB.insertNewOrder(c_phone, create_date, shop_id))
            {
                pn_product.Enabled = true;
                DataTable data = sqlDB.showMenuInShop(shop_id);
                dgv_menu.DataSource = data;
                SqlConnection cnt = sqlDB.getConnection();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 order_id FROM ORDER_LIST ORDER BY order_id DESC ", cnt);
                cnt.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    order_id = int.Parse(rd["order_id"].ToString());
                }
                cnt.Close();
            }
            else
                MessageBox.Show("Thất bại");
            
        }

        private void dgv_order_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            int rowSelect = dgv_menu.CurrentRow.Index;
            int product_id = Int32.Parse( dgv_menu.Rows[rowSelect].Cells[0].Value.ToString());
            int quantity = int.Parse(txt_amount.Text);
            double cost = double.Parse(dgv_menu.Rows[rowSelect].Cells[2].Value.ToString());
            double price = quantity * cost;
            if (sqlDB.insertProductInOrder(order_id, product_id, quantity, price))
            {
                showInfoPayment();
                showVoucherItems(txt_c_phone.Text);
                showProductInOrder();
                pn_payment.Enabled = true; 
            }
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            string payment_method = cbx_payment_method.Text;
            string voucher_id = cbx_voucher.Text;
            if (voucher_id == "")
                voucher_id = null;
            if (sqlDB.checkoutPayment(order_id, voucher_id, payment_method))
            {
                MessageBox.Show("Đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void showInfoPayment()
        {
            SqlConnection sqlcnt = sqlDB.getConnection();
            try
            {
                string query = "SELECT payment_amount FROM payment WHERE order_id=@order_id" ;
                sqlcnt.Open();
                SqlCommand cmd = new SqlCommand(query,sqlcnt);
                cmd.Parameters.AddWithValue("@order_id", order_id);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    txt_totalprice.Text = rd["payment_amount"].ToString();
                }
                sqlcnt.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showVoucherItems(string c_phone)
        {
            SqlConnection sqlcnt = sqlDB.getConnection();
            cbx_voucher.Items.Clear();
            try
            {
                string query = "view_voucher_of_cus";
                sqlcnt.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcnt);
                cmd.Parameters.AddWithValue("@c_phone_number", c_phone);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cbx_voucher.Items.Add(rd["voucher_id"].ToString());
                }
                sqlcnt.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showProductInOrder()
        {
            SqlConnection cnt = sqlDB.getConnection();
            try
            {
                string query = "SELECT * FROM show_product_in_order(@order_id)";
               
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.Parameters.AddWithValue("@order_id", order_id);
                SqlDataAdapter apt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                apt.Fill(data);
                dgv_order_product.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        private void pn_order_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
