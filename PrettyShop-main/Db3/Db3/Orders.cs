using Db3.Model;
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

namespace Db3
{
    public partial class Orders : Form
    {
        private Customer currentCustomer;
        
        public Orders(Customer customer)
        {
            InitializeComponent();
            InitializeListView();
            this.currentCustomer = customer;
            LoadProducts();
        }

        private void InitializeListView()
        {
            // Создаем столбцы для ListView
            OrderList.Columns.Add("Game", 200);
            OrderList.Columns.Add("Description", 200);
            OrderList.Columns.Add("Price", 100);
        }
        private void LoadProducts()
        {
            using (DbConnector db = new DbConnector())
            {
                db.OpenConnection();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                {
                    MySqlCommand command = new MySqlCommand("SELECT p.* FROM product p JOIN order_items oi ON p.product_id = oi.product_id JOIN `order` o ON oi.order_id = o.order_id WHERE o.customer_id = @userId", db.GetConnection());
                    command.Parameters.AddWithValue("@userId", currentCustomer.Id);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);

                    OrderList.Controls.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string productName = row["name"].ToString();
                        string productPrice = row["price"].ToString();
                        string productDesc = row["description"].ToString();
                        
                        ListViewItem item = new ListViewItem(new string[] { productName, productDesc, productPrice });
                        OrderList.Items.Add(item);
                    }
                }
                db.CloseConnection();
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm(currentCustomer);
            shopForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
