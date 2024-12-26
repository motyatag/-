using Db3.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Db3
{
    public partial class LoginForm : Form
    {
        Point lastPoint;
        public LoginForm()
        {
            InitializeComponent();
            PassBox.UseSystemPasswordChar = true;
    }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            

            DbConnector db = new DbConnector();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM customer WHERE nickname = @ul AND password = @pb", db.GetConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = LogBox.Text;
            command.Parameters.Add("@pb", MySqlDbType.VarChar).Value = PassBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0 )
            {
                Customer currentCustomer = new Customer();
                currentCustomer.Id = Convert.ToInt32(dataTable.Rows[0]["customer_id"]);
                currentCustomer.Name = LogBox.Text;
                currentCustomer.Password = PassBox.Text;
                currentCustomer.Address = dataTable.Rows[0]["address"].ToString();
                currentCustomer.Phone = dataTable.Rows[0]["phone"].ToString();

                this.Hide();
                LK lK = new LK(currentCustomer);
                lK.Show();
            }
            else
            {
                MessageBox.Show("Ошибочка вышла");
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PassBox.UseSystemPasswordChar = false;
            }
            else
            {
                PassBox.UseSystemPasswordChar = true;
            }
        }
    }
}
