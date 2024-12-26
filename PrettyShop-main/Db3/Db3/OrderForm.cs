using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Db3.Model; 
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Db3
{
    public partial class OrderForm : Form
    {
        private Customer currentCustomer;
        private List<OrderItem> orderItems = new List<OrderItem>(); // Список для хранения товаров в заказе

        public OrderForm(Customer customer)
        {
            InitializeComponent();
            this.currentCustomer = customer;
            LoadProducts();
            UpdateFinalPrice();
            addressBox.Text = currentCustomer.Address;
        }

        private void LoadProducts()
        {
            using (DbConnector db = new DbConnector())
            {
                db.OpenConnection();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                {
                    MySqlCommand command = new MySqlCommand("SELECT p.*, c.amount FROM product p JOIN cart c ON p.product_id = c.product_id WHERE c.customer_id = @userId", db.GetConnection());
                    command.Parameters.AddWithValue("@userId", currentCustomer.Id);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);

                    Order.Controls.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string productName = row["name"].ToString();
                        string productPrice = row["price"].ToString(); 
                        string productDesc = row["description"].ToString();
                        int quantity = Convert.ToInt32(row["amount"]);

                        OrderItem orderItem = new OrderItem(productName, productPrice, quantity); 
                        orderItems.Add(orderItem);

                        ListViewItem item = new ListViewItem(new string[] {productName, productPrice, quantity.ToString()});
                        Order.Items.Add(item);
                    }
                }
                db.CloseConnection();
            }
        }

        private void UpdateFinalPrice()
        {
            float finalPrice = 0;
            foreach (OrderItem orderItem in orderItems)
            {
                float productPrice = Convert.ToSingle(orderItem.Quantity); // Переделать цену в числовой формат
                int quantity = orderItem.QuantityControl;
                finalPrice += productPrice * quantity;
            }

            finalPriceLabel.Text = finalPrice.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartForm cartForm = new CartForm(currentCustomer);
            cartForm.Show();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            using (DbConnector db = new DbConnector())
            {
                db.OpenConnection();

                // Получаем выбранный способ оплаты
                string paymentMethod = GetSelectedPaymentMethod();
                if (paymentMethod == null)
                {
                    MessageBox.Show("Выберите метод оплаты.");
                    return;
                }

                // Вставляем общую информацию о заказе в таблицу orders
                MySqlCommand command = new MySqlCommand("INSERT INTO `order` (customer_id, address, final_price, payment) VALUES (@customer_id, @address, @final_price, @payment)", db.GetConnection());
                command.Parameters.AddWithValue("@customer_id", currentCustomer.Id);
                command.Parameters.AddWithValue("@address", string.IsNullOrEmpty(addressBox.Text) ? currentCustomer.Address : addressBox.Text);
                command.Parameters.AddWithValue("@final_price", finalPriceLabel.Text); // Передаем общую стоимость заказа из finalPriceLabel
                command.Parameters.AddWithValue("@payment", paymentMethod);

                command.ExecuteNonQuery();
                long orderId = command.LastInsertedId;

                // Вставляем каждую позицию заказа в таблицу order_items
                foreach (OrderItem orderItem in orderItems)
                {
                    // Используем данные из объекта OrderItem для вставки в базу данных
                    string productName = orderItem.ProductName;
                    int quantity = orderItem.QuantityControl;
                    float price = Convert.ToSingle(orderItem.Quantity); // Переделать цену в числовой формат

                    command = new MySqlCommand("SELECT product_id FROM product WHERE name = @name", db.GetConnection());
                    command.Parameters.AddWithValue("@name", productName);
                    int productId = Convert.ToInt32(command.ExecuteScalar());

                    command = new MySqlCommand("INSERT INTO `order_items` (order_id, product_id, amount) VALUES (@order_id, @product_id, @quantity)", db.GetConnection());
                    command.Parameters.AddWithValue("@order_id", orderId);
                    command.Parameters.AddWithValue("@product_id", productId);
                    command.Parameters.AddWithValue("@quantity", quantity);

                    command.ExecuteNonQuery();
                }

                db.CloseConnection();
            }
            MessageBox.Show("Заказ успешно оформлен!");
            this.Hide();
            ShopForm shopForm = new ShopForm(currentCustomer);
            shopForm.Show();
        }

        private string GetSelectedPaymentMethod()
        {
            foreach (object item in PaymentBox.CheckedItems)
            {
                return item.ToString();
            }
            return null;
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
