﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FINAL_PROJECT_DBMS.Model
{
    public class DAOConnection
    {

        public static string cntStr;
  

        public DAOConnection()
        {
            
        }
        public SqlConnection getConnection()
        {
            SqlConnection cnt = null;
            try
            {
                cnt = new SqlConnection(cntStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cnt;
        }
        public bool login(string username,string password)
        {
            SqlConnection cnt = getConnection();
            string sql = "SELECT username,password FROM EMPLOYEE " +
                "WHERE username='" + username + "' and password ='" + password + "'";
            SqlDataAdapter adt = null;
            DataTable data = new DataTable();
            try
            {
                adt = new SqlDataAdapter(sql, cnt);
                adt.Fill(data);
                if (data.Rows.Count > 0)
                {
                    return true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
           
        }
        public bool addNewEmp(string name,string phone, string role,string begin_date,string shopid,string username,string pass)
        {
            try
            {
                SqlConnection cnt = getConnection();
                string query = "add_new_employee";
                cnt.Open();
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@emp_name", SqlDbType.NChar).Value = name;
                cmd.Parameters.AddWithValue("@phone_number", SqlDbType.Char).Value = phone;
                cmd.Parameters.AddWithValue("@emp_role", SqlDbType.Char).Value = role;
                cmd.Parameters.AddWithValue("@begin_date", SqlDbType.Date).Value = begin_date;
                cmd.Parameters.AddWithValue("@shop_id", SqlDbType.Char).Value = shopid;
                cmd.Parameters.AddWithValue("@username", SqlDbType.Char).Value = username;
                cmd.Parameters.AddWithValue("@password", SqlDbType.Char).Value = pass;
                cmd.ExecuteNonQuery();
                cnt.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        public bool addNewCustomer(string c_phone, string Birthday, string address, string type)
        {
            try
            {
                SqlConnection cnt = getConnection();
                cnt.Open();
                string query = "add_new_Customer ";
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@c_phone", SqlDbType.Char).Value = c_phone;
                cmd.Parameters.AddWithValue("@birthday", SqlDbType.Date).Value = Birthday;
                cmd.Parameters.AddWithValue("@address", SqlDbType.NChar).Value = address;
                cmd.Parameters.AddWithValue("@Type_cus", SqlDbType.Char).Value = type;
                cmd.ExecuteNonQuery();
                cnt.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool addNewVoucher(string VoucherID, string discount, string description, string start_date, string end_date, string contraint)
        {
            try
            {
                SqlConnection cnt = getConnection();
                string query = "add_new_Voucher";
                cnt.Open();
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@voucher_id", SqlDbType.Char).Value = VoucherID;
                cmd.Parameters.AddWithValue("@discount", SqlDbType.Real).Value = discount;
                cmd.Parameters.AddWithValue("@description", SqlDbType.NChar).Value = description;
                cmd.Parameters.AddWithValue("@start_day", SqlDbType.Date).Value = start_date;
                cmd.Parameters.AddWithValue("@end_day", SqlDbType.Date).Value = end_date;
                cmd.Parameters.AddWithValue("@voucher_constraint", SqlDbType.Char).Value = contraint;
                cmd.ExecuteNonQuery();
                cnt.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        public bool insertNewOrder(string c_phone,string createDate,string shopid)
        {
            try
            {
                SqlConnection cnt = getConnection();
                cnt.Open();     
                string query = "INSERT INTO order_list(c_phone_number,create_day,shop_id) " +
                    "VALUES (@c_phone,@create_day,@shop_id)";
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.Parameters.AddWithValue("@c_phone", c_phone);
                cmd.Parameters.AddWithValue("@create_day", DbType.Date).Value = createDate;
                cmd.Parameters.AddWithValue("@shop_id", shopid);
                int change = cmd.ExecuteNonQuery();
                if (change != 0)
                    return true;
                cnt.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public DataTable showMenuInShop(string shop_id)
        {
            try
            {
                SqlConnection cnt = getConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.show_menu_in_shop(@shop_id)", cnt);
                cmd.Parameters.AddWithValue("@shop_id", shop_id);
                SqlDataAdapter apt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
        public bool insertProductInOrder(int order_id,int product_id,
            int quantity,double price)
        {
            try
            {
                SqlConnection cnt = getConnection();
                string query = "INSERT INTO order_product VALUES" +
                    "(@order_id,@product_id,@quantity,@price)";
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.Parameters.AddWithValue("@order_id", order_id);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", DbType.Double).Value = price;
                cnt.Open();
                cmd.ExecuteNonQuery();
                cnt.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        public DataTable empOverOneMonth()
        {
            SqlConnection sqlCnt = getConnection();
            try
            {
                string query = "SELECT * FROM over_1_month_work";
                SqlDataAdapter apt = new SqlDataAdapter(query, sqlCnt);
                DataTable dataTable = new DataTable();
                apt.Fill(dataTable);
                return dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable showUnpaidOrderlist()
        {
            SqlConnection sqlCnt = getConnection();
            try
            {
                string query = "SELECT * FROM UNPAID_ORDER";
                SqlDataAdapter apt = new SqlDataAdapter(query,sqlCnt);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public bool checkoutPayment(int orderID,string voucher_id,string payment)
        {
            SqlConnection sqlCnt = getConnection();
            try
            {
                string query = "checkout_order";
                sqlCnt.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order_id", orderID);
                cmd.Parameters.AddWithValue("@payment_method", payment);
                if(voucher_id == null)
                    cmd.Parameters.AddWithValue("@voucher_id", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@voucher_id", voucher_id);
                cmd.ExecuteNonQuery();
                sqlCnt.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool deleteProduct(string name)
        {
            SqlConnection cnt = getConnection();
            string query = "del_product";
            try
            {
                cnt.Open();
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name_product", name);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cnt.Close();
            }
            return false;
        }
        public DataTable showRankProduct()
        {
            SqlConnection cnt = getConnection();
            try
            {
                string query = "ranking_of_product";
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter apt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public bool deleteEmployee(string name)
        {
            SqlConnection cnt = getConnection();
            string query = "del_employee";
            try
            {
                cnt.Open();
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@emp_name", name);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cnt.Close();
            }
            return false;
        }
        public bool updateProduct(int id,double price,double cost)
        {
            SqlConnection cnt = getConnection();
            string query = "update_product";
            try
            {
                cnt.Open();
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@product_id", id);
                cmd.Parameters.AddWithValue("@cost", price);
                cmd.Parameters.AddWithValue("@production_cost", cost);
                cmd.ExecuteNonQuery();
                cnt.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                cnt.Close();
            }
            return false;
        }
        public bool updateRole(int id, string role)
        {
            SqlConnection cnt = getConnection();
            string query = "update_employee";
            try
            {
                cnt.Open();
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@emp_id", id);
                cmd.Parameters.AddWithValue("@emp_role", role);
                cmd.ExecuteNonQuery();
                cnt.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                cnt.Close();
            }
            return false;
        }
        public bool updatePayment(string method, string status, double amount, int id)
        {
            SqlConnection cnt = getConnection();
            string query = "update_payment";
            try
            {
                cnt.Open();
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@payment_method", method);
                cmd.Parameters.AddWithValue("@payment_status", status);
                cmd.Parameters.AddWithValue("@payment_amount", amount);
                cmd.Parameters.AddWithValue("@order_id", id);
                cmd.ExecuteNonQuery();
                cnt.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                cnt.Close();
            }
            return false;
        }
        public bool delOrder(int order_id)
        {
            SqlConnection cnt = getConnection();
            string query = "delete_order_trans";
            try
            {
                cnt.Open();
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order_id", order_id);
                cmd.ExecuteNonQuery();
                cnt.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                cnt.Close();
            }
            return false;
        }
        public DataTable showDiffBtwCost(string shop_id)
        {
            SqlConnection cnt = getConnection();
            try
            {
                string query = "diff_btw_cost_each_month";
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@shop_id", shop_id);
                SqlDataAdapter apt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable showShopRevenue(int month)
        {
            SqlConnection cnt = getConnection();
            try
            {
                string query = "shop_revenue";
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@month", month);
                SqlDataAdapter apt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable showcountvoucherinmonth(int month)
        {
                SqlConnection cnt = getConnection();
                string query = "count_voucher_in_month";
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@month", month);
                SqlDataAdapter apt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data; 
        }

        public DataTable showTotalPayment(string PHONE_CUSTOMER)

        {
            SqlConnection cnt = getConnection();
            try
            {

                string query = "SELECT * FROM view_total_payment_of_cus(@c_phone_number) ";
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.Parameters.AddWithValue("@c_phone_number", SqlDbType.Char).Value = PHONE_CUSTOMER;
                SqlDataAdapter apt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable showBestSellProduct(string SHOPID)
        {
            SqlConnection cnt = getConnection();
            try
            {
                string query = "products_best_sell_in_shop";
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@shop_id", SHOPID);
                SqlDataAdapter apt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable showFee()
        {
            SqlConnection sqlCnt = getConnection();
            try
            {
                string query = "SELECT * FROM FEE";
                SqlDataAdapter apt = new SqlDataAdapter(query, sqlCnt);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable showHcmShop()
        {
            SqlConnection sqlCnt = getConnection();
            try
            {
                string query = "SELECT * FROM HCM_SHOP";
                SqlDataAdapter apt = new SqlDataAdapter(query, sqlCnt);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable showVoucherToday()
        {
            SqlConnection sqlCnt = getConnection();
            try
            {
                string query = "SELECT * FROM VOUCHER_TODAY";
                SqlDataAdapter apt = new SqlDataAdapter(query, sqlCnt);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable showRevenueInDay(string date)
        {
            
            SqlConnection cnt = getConnection();
            try
            {
                string query = "revenue_in_day";
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@day",date );
                SqlDataAdapter apt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable showProductInDay(string date)
        {

            SqlConnection cnt = getConnection();
            try
            {
                string query = "product_in_day";
                SqlCommand cmd = new SqlCommand(query, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@day", date);
                SqlDataAdapter apt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }  
}
