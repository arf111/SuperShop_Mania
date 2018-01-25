﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_Management.Admin
{
    public partial class Warehouse_Distribution : Form
    {
        private Database.DatabaseHandler db;
        private String query;
        private String prod_name, branch_id, prod_quantity;

        private void ok_bttn_Click(object sender, EventArgs e)
        {

        }

        private void insert_bttn_Click(object sender, EventArgs e)
        {
            db.openConnection();

            prod_name = product_name.Text;
            branch_id = branch_name.Text;
            prod_quantity = product_quantity.Text;

            query = "INSERT INTO stores_in(P_ID, P_Quantity, Branch_ID) " +
            "VALUES((SELECT p.P_ID FROM product as p WHERE p.P_Name = '" + prod_name + "'),'" + prod_quantity + "','" + branch_id + "')";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Inserted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin_View().Show();
        }

        private void view_bttn_Click(object sender, EventArgs e)
        {
            db.openConnection();

            query = "SELECT p.P_Name as 'Product Name',st.P_Quantity as 'Product Quantity',st.Branch_ID as 'Branch' FROM stores_in as st " +
            "INNER JOIN product AS p ON st.P_ID = p.P_ID";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();

                myAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();

                myAdapter.Fill(dt);

                sales_distributeView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.closeConnection();
        }

        public Warehouse_Distribution()
        {
            db = new Database.DatabaseHandler();
            InitializeComponent();
        }
    }
}
