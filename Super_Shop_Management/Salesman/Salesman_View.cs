using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_Management
{
    public partial class Salesman_View : Form
    {
        private int m_ID = 1;
        private Database.DatabaseHandler db;
        private String query;
        private int flag = 0;

        private int q = 0, p = 0;
        private double total_Cost = 0;


        public Salesman_View()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void set_m_ID(int m_ID)
        {
            this.m_ID = m_ID;
        }


        private void transactionAdd_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(salesman_quantity.Text);


            db = new Database.DatabaseHandler();
            db.openConnection();
            int id = Convert.ToInt32(salesman_P_ID.Text);
            query = "select P_Name  from product where P_ID=" + id;
            string p_Name = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                cmd.ExecuteNonQuery();
                p_Name = (String)cmd.ExecuteScalar();

            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }
            db.closeConnection();
            db.openConnection();
            query = "select Selling_Price  from product where P_ID=" + id;
            //string s_Price;
            int price = 0;
            //double price = 0.0 ;

            try
            {
                //MySql.Data.MySqlClient.MySqlCommand myCommand =
                //new MySql.Data.MySqlClient.MySqlCommand(insertQuery, connection);

                //  MySql.Data.MySqlClient.MySqlCommand cmd =
                //    new MySql.Data.MySqlClient.MySqlCommand(query, db.getmyConn());

                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                cmd.ExecuteNonQuery();
                price = Convert.ToInt32(cmd.ExecuteScalar());
                p = price;
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }
            db.closeConnection();
            if (flag == 0)
            {
                salesman_gridview.Columns.Add("Product Name ", "Product Name ");
                salesman_gridview.Columns.Add("Price ", "Price_Per_Unit");
                salesman_gridview.Columns.Add("Quantity ", "Quantity");
                flag = 1;
            }
            salesman_gridview.Rows.Add(new object[] { p_Name, price, quantity });
            q = Convert.ToInt32(salesman_quantity.Text);
            total_Cost = total_Cost + (double)(p * q);

        }

        private void member_bttn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Salesman.Check_Membership().Show();

        }

        private void transactionTotalAmount_Click(object sender, EventArgs e)
        {
            if (m_ID == 1)
                total_Cost = total_Cost - (total_Cost * 0.05);
            if (m_ID == 2)
                total_Cost = total_Cost - (total_Cost * 0.1);
            if (m_ID == 3)
                total_Cost = total_Cost - (total_Cost * 0.2);
            if (m_ID == 4)
                total_Cost = total_Cost - (total_Cost * 0.25);

            salesview_TotalAmountText.Text = Convert.ToString(total_Cost);
        }

        private void transactionSave_Click(object sender, EventArgs e)
        {
            db = new Database.DatabaseHandler();
            db.openConnection();

            //query = "INSERT INTO customer(C_Name,Email,M_ID) VALUES('" + customer_Fname.Text + "','" + customer_Email.Text + "'," + num + ")";
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }

            db.closeConnection();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Sales_View().Show();
        }
    }
}
