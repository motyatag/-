using Db3.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db3
{
    public partial class LK : Form
    {
        public Customer currentCustomer;

        public LK(Customer customer)
        {
            InitializeComponent();
            this.currentCustomer = customer;

            LoadUserPhoto();
            NameBox.Text = currentCustomer.Name;
            PassBox.Text = currentCustomer.Password;
            AddressBox.Text = currentCustomer.Address;
            PhoneBox.Text = currentCustomer.Phone;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DbConnector db = new DbConnector();
            db.UpdateUserData(NameBox.Text, PassBox.Text, AddressBox.Text, currentCustomer.Phone);
            MessageBox.Show("Done!");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DbConnector db = new DbConnector();
            db.DeleteUserData(currentCustomer.Name);
            MessageBox.Show("Account have been successfully deleted");

            this.Hide();
            ShopForm shopForm = new ShopForm();
            shopForm.Show();
        }
        private void LoadUserPhoto()
        {
            using (DbConnector db = new DbConnector())
            {
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT photo FROM customer WHERE customer_id = @customerId", db.GetConnection());
                command.Parameters.AddWithValue("@customerId", currentCustomer.Id);
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    byte[] photoBytes = (byte[])result;
                    using (MemoryStream ms = new MemoryStream(photoBytes))
                    {
                        pictureBoxUserPhoto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Устанавливаем изображение по умолчанию, если фото отсутствует
                    pictureBoxUserPhoto.Image = Properties.Resources.DefaultUserPhoto; // Убедитесь, что у вас есть изображение по умолчанию в ресурсах
                }
                db.CloseConnection();
            }
        }

        private void buttonUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pictureBoxUserPhoto.Image = Image.FromFile(filePath);

                    // Save photo to database
                    SaveUserPhoto(filePath);
                }
            }
        }

        private void SaveUserPhoto(string filePath)
        {
            byte[] photoBytes = File.ReadAllBytes(filePath);

            using (DbConnector db = new DbConnector())
            {
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("UPDATE customer SET photo = @photo WHERE customer_id = @customerId", db.GetConnection());
                command.Parameters.AddWithValue("@photo", photoBytes);
                command.Parameters.AddWithValue("@customerId", currentCustomer.Id);
                command.ExecuteNonQuery();
                db.CloseConnection();
            }
        }


        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm(currentCustomer);
            shopForm.Show();
        }

        private void OutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm(null);
            shopForm.Show();
            

        }
    }
}
