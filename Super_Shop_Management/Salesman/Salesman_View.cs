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
        private Database.DatabaseHandler db;
        private String query;
        private int flag = 0;

        public Salesman_View()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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

            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }
            db.closeConnection();
            if (flag == 0)
            {
                salesman_gridview.Columns.Add("Product Name ", "Product Name ");
                salesman_gridview.Columns.Add("Price ", "Price");
                salesman_gridview.Columns.Add("Quantity ", "Quantity");
                flag = 1;
            }
            salesman_gridview.Rows.Add(new object[] { p_Name, price, quantity });
        }

        private void member_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Salesman.Check_Membership().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Sales_View().Show();
        }
    }
}
