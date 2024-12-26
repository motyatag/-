using Db3.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Db3
{
    public partial class ShopForm : Form
    {
        private Customer currentCustomer;

        public ShopForm()
        {
            InitializeComponent();
            InitializeListView();
            LoadProducts();
            Products.SelectedIndexChanged += Products_SelectedIndexChanged;
        }

        public ShopForm(Customer customer)
        {
            InitializeComponent();
            InitializeListView();
            this.currentCustomer = customer;
            LoadProducts();
            Products.SelectedIndexChanged += Products_SelectedIndexChanged;
        }

        private void InitializeListView()
        {
            // Создаем столбцы для ListView
            Products.Columns.Add("Game", 200);
            Products.Columns.Add("Description", 200);
            Products.Columns.Add("Price", 100);
        }

        private void LoadProducts()
        {
            using (DbConnector db = new DbConnector())
            {
                db.OpenConnection();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM product", db.GetConnection()))
                {
                    adapter.Fill(dataTable);
                    Products.Items.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string productName = row["name"].ToString();
                        string productPrice = row["price"].ToString();
                        string productDesc = row["description"].ToString();
                        byte[] productImageBytes = (byte[])row["image"]; // Преобразуем BLOB данные в байтовый массив

                        // Конвертируем байтовый массив в изображение
                        Image productImage = ByteArrayToImage(productImageBytes);

                        // Создаем элемент ListViewItem и добавляем его в ListView
                        ListViewItem item = new ListViewItem(new string[] { productName, productDesc, productPrice });
                        item.Tag = productImage; // Сохраняем изображение в свойстве Tag для последующего использования
                        Products.Items.Add(item);
                    }
                }
                db.CloseConnection();
            }
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Products.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Products.SelectedItems[0];
                Image productImage = (Image)selectedItem.Tag; // Извлекаем изображение из свойства Tag
                ProductPictureBox.Image = productImage; // Отображаем изображение в PictureBox
            }
            else
            {
                ProductPictureBox.Image = null; // Очищаем PictureBox, если ничего не выбрано
            }
        }
        private void AddToCart_Click(object sender, EventArgs e)
        {
            if (currentCustomer == null)
            {
                MessageBox.Show("Пожалуйста, выполните вход в личный кабинет!");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                if (Products.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = Products.SelectedItems[0];
                    string productName = selectedItem.SubItems[0].Text;

                    using (DbConnector db = new DbConnector())
                    {
                        db.OpenConnection();
                        using (MySqlCommand command = new MySqlCommand("INSERT INTO cart (customer_id, product_id) SELECT @userId, product_id FROM product WHERE name = @productName", db.GetConnection()))
                        {
                            command.Parameters.AddWithValue("@userId", currentCustomer.Id);
                            command.Parameters.AddWithValue("@productName", productName);
                            command.ExecuteNonQuery();
                        }
                        db.CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите продукт для добавления в корзину.");
                }
            }
        }
            

        public bool IsUserAuthenticated()
        {
            // Логика проверки аутентификации пользователя
            return currentCustomer != null;
        }

        // Основной метод, где создается CartForm
        public void Cart_Click(object sender, EventArgs e)
        {
            if (!IsUserAuthenticated())
            {
                MessageBox.Show("Пожалуйста, войдите в систему для доступа к корзине.");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                CartForm cartForm = new CartForm(currentCustomer);
                cartForm.Show();
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LkBtn_Click(object sender, EventArgs e)
        {
            if (!IsUserAuthenticated())
            {
                MessageBox.Show("Пожалуйста, войдите в систему!");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                this.Hide();
                LK lK = new LK(currentCustomer);
                lK.Show();
            }
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (currentCustomer == null)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                this.Hide();
                ShopForm shopForm = new ShopForm(null);
                shopForm.Show();
            }
            
        }

        private void Like_Click(object sender, EventArgs e)
        {
            if (currentCustomer == null)
            {
                MessageBox.Show("Пожалуйста, выполните вход в личный кабинет!");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                if (Products.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = Products.SelectedItems[0];
                    string productName = selectedItem.SubItems[0].Text;

                    using (DbConnector db = new DbConnector())
                    {
                        db.OpenConnection();
                        using (MySqlCommand command = new MySqlCommand("INSERT INTO liked (customer_id, product_id) SELECT @userId, product_id FROM product WHERE name = @productName", db.GetConnection()))
                        {
                            command.Parameters.AddWithValue("@userId", currentCustomer.Id);
                            command.Parameters.AddWithValue("@productName", productName);
                            command.ExecuteNonQuery();
                        }
                        db.CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите продукт для добавления в избранное.");
                }
            }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }
        private void LikedBtn_Click(object sender, EventArgs e)
        {
            if (!IsUserAuthenticated())
            {
                MessageBox.Show("Пожалуйста, войдите в систему для доступа к избранному.");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                this.Hide();
                LikedForm likedForm = new LikedForm(currentCustomer);
                likedForm.Show();
            }
            
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            if (currentCustomer == null)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                this.Hide();
                Orders orders = new Orders(currentCustomer);
                orders.Show();
            }
        }
    }
}
