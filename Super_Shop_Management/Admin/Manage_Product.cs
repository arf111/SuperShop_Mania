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
    public partial class Manage_Product : Form
    {
        private Database.DatabaseHandler db;
        private Database.DatabaseAdmin dbAdmin;
        private String query;
        private String s_ID, prod_name, quantity, selling_price, s_date, buy_price, catg;


        private void view_bttn_Click(object sender, EventArgs e)
        {
            db.openConnection();

            query = "SELECT w.S_ID as Supply_ID,w.S_Date as Supply_Date, p.P_Name as Product_Name,p.Selling_Price,w.P_Quantity as Quantity, w.Price as Buying_Price,C_Name as Category " +
                    "FROM product as p" +
                    " inner join category as c on c.C_ID = p.C_ID" +
                    " inner join warehouse as w on w.P_ID = p.P_ID";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();

                myAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();

                myAdapter.Fill(dt);

                productGridView.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            db.closeConnection();
        }

        private void pro_update_Click(object sender, EventArgs e)
        {
            catg = up_product.SelectedItem.ToString();
            prod_name = up_name.Text;
            selling_price = up_price.Text;
            s_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            buy_price = warehouse_Price.Text;
            quantity = wareHouse_Inventory.Text;

            if (catg == "Electronics")
            {
                catg = "2";
            }
            else if (catg == "Cosmetics")
            {
                catg = "1";
            }

            dbAdmin.updateprod(prod_name, catg, selling_price);
            dbAdmin.warehouseUpdate(s_ID, s_date, quantity, buy_price);
        }

        private void productGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dateTimePicker1.Value = Convert.ToDateTime(productGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            s_ID = productGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            up_name.Text = productGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            up_price.Text = productGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            warehouse_Price.Text = productGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            wareHouse_Inventory.Text = productGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            up_product.Text = productGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void pro_delete_Click(object sender, EventArgs e)
        {
            prod_name = up_name.Text;

            dbAdmin.deleteprod(prod_name);
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin_View().Show();
        }

        private void pro_insert_Click(object sender, EventArgs e)
        {
            catg = up_product.SelectedItem.ToString();
            prod_name = up_name.Text;
            selling_price = up_price.Text;
            s_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            buy_price = warehouse_Price.Text;
            quantity = wareHouse_Inventory.Text;

            if (catg == "Electronics")
            {
                catg = "2";
            }
            else if (catg == "Cosmetics")
            {
                catg = "1";
            }

            dbAdmin.productAdd(prod_name, catg, selling_price);
            dbAdmin.warehouseAdd(prod_name, s_date, quantity, buy_price);
        }

        public Manage_Product()
        {
            db = new Database.DatabaseHandler();
            dbAdmin = new Database.DatabaseAdmin();

            InitializeComponent();

            loadCategory();
        }

        private void loadCategory()
        {
            db.openConnection();

            query = "SELECT C_Name FROM category";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    up_product.Items.Add(dataReader.GetString("C_Name"));
                }

                up_product.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.closeConnection();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
