using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db3.Model;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Db3
{

    public partial class LikedForm : Form
    {
        private Customer currentCustomer;
        public LikedForm(Customer currentCustomer)
        {
            InitializeComponent();
            this.currentCustomer = currentCustomer;
            LoadLiked();
            Liked.SelectedIndexChanged += Cart_SelectedIndexChanged;
        }


        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void Cart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Liked.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Liked.SelectedItems[0];
                Image productImage = (Image)selectedItem.Tag; 
                ProductPictureBox.Image = productImage; 
            }
            else
            {
                ProductPictureBox.Image = null; 
            }
        }
        private void LoadLiked()
        {
            using (DbConnector db = new DbConnector())
            {
                db.OpenConnection();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                {
                    MySqlCommand command = new MySqlCommand("SELECT p.* FROM product p JOIN liked c ON p.product_id = c.product_id WHERE c.customer_id = @userId", db.GetConnection());
                    command.Parameters.AddWithValue("@userId", currentCustomer.Id);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);

                    Liked.Items.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string productName = row["name"].ToString();
                        string productPrice = row["price"].ToString();
                        string productDesc = row["description"].ToString();
                        byte[] productImageBytes = (byte[])row["image"]; 

                        Image productImage = ByteArrayToImage(productImageBytes);
                        ListViewItem item = new ListViewItem(new string[] { productName, productDesc, productPrice });
                        item.Tag = productImage;
                        Liked.Items.Add(item);
                    }
                }
                db.CloseConnection();
            }
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LK lK = new LK(currentCustomer);
            lK.Show();
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            if (Liked.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Liked.SelectedItems[0];
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

                    using (MySqlCommand command = new MySqlCommand("DELETE FROM liked WHERE customer_id = @userId AND product_id = (SELECT product_id FROM product WHERE name = @productName)", db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@userId", currentCustomer.Id);
                        command.Parameters.AddWithValue("@productName", productName);
                        command.ExecuteNonQuery();
                    }

                    db.CloseConnection();
                }
                LoadLiked();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите продукт для добавления в корзину.");
            }
        }

        private void RemoveFromLiked_Click(object sender, EventArgs e)
        {
            if (Liked.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Liked.SelectedItems[0];
                string productName = selectedItem.SubItems[0].Text;

                using (DbConnector db = new DbConnector())
                {
                    db.OpenConnection();
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM liked WHERE customer_id = @userId AND product_id = (SELECT product_id FROM product WHERE name = @productName)", db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@userId", currentCustomer.Id);
                        command.Parameters.AddWithValue("@productName", productName);
                        command.ExecuteNonQuery();
                    }
                    db.CloseConnection();
                }
                LoadLiked();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите продукт для удаления из избранного.");
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm(currentCustomer);
            shopForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartForm cartForm = new CartForm(currentCustomer);
            cartForm.Show();
        }
    }
}
