using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Windows.Forms;
using System;

namespace Db3
{
    partial class ShopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.main = new System.Windows.Forms.Panel();
            this.Orders = new System.Windows.Forms.Label();
            this.LikedBtn = new System.Windows.Forms.Label();
            this.CartBtn = new System.Windows.Forms.Label();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.ListView();
            this.LogInBtn = new System.Windows.Forms.PictureBox();
            this.LkBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main.BackColor = System.Drawing.Color.Black;
            this.main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.main.Controls.Add(this.Orders);
            this.main.Controls.Add(this.LikedBtn);
            this.main.Controls.Add(this.CartBtn);
            this.main.Controls.Add(this.ProductPictureBox);
            this.main.Controls.Add(this.pictureBox1);
            this.main.Controls.Add(this.BtnLogin);
            this.main.Controls.Add(this.Products);
            this.main.Controls.Add(this.LogInBtn);
            this.main.Controls.Add(this.LkBtn);
            this.main.Controls.Add(this.panel2);
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1200, 800);
            this.main.TabIndex = 2;
            // 
            // Orders
            // 
            this.Orders.AllowDrop = true;
            this.Orders.AutoSize = true;
            this.Orders.Font = new System.Drawing.Font("Minecraft 1.1", 15.75F, System.Drawing.FontStyle.Bold);
            this.Orders.ForeColor = System.Drawing.Color.Lavender;
            this.Orders.Location = new System.Drawing.Point(687, 127);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(119, 27);
            this.Orders.TabIndex = 13;
            this.Orders.Text = "Заказы";
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // LikedBtn
            // 
            this.LikedBtn.AllowDrop = true;
            this.LikedBtn.AutoSize = true;
            this.LikedBtn.Font = new System.Drawing.Font("Minecraft 1.1", 15.75F, System.Drawing.FontStyle.Bold);
            this.LikedBtn.ForeColor = System.Drawing.Color.Lavender;
            this.LikedBtn.Location = new System.Drawing.Point(367, 127);
            this.LikedBtn.Name = "LikedBtn";
            this.LikedBtn.Size = new System.Drawing.Size(172, 27);
            this.LikedBtn.TabIndex = 12;
            this.LikedBtn.Text = "Избранное\r\n";
            this.LikedBtn.Click += new System.EventHandler(this.LikedBtn_Click);
            // 
            // CartBtn
            // 
            this.CartBtn.AllowDrop = true;
            this.CartBtn.AutoSize = true;
            this.CartBtn.Font = new System.Drawing.Font("Minecraft 1.1", 15.75F, System.Drawing.FontStyle.Bold);
            this.CartBtn.ForeColor = System.Drawing.Color.Lavender;
            this.CartBtn.Location = new System.Drawing.Point(545, 127);
            this.CartBtn.Name = "CartBtn";
            this.CartBtn.Size = new System.Drawing.Size(136, 27);
            this.CartBtn.TabIndex = 11;
            this.CartBtn.Text = "Корзина";
            this.CartBtn.Click += new System.EventHandler(this.Cart_Click);
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.BackColor = System.Drawing.Color.Black;
            this.ProductPictureBox.Image = global::Db3.Properties.Resources._9dce24bf941426e823775d5d95bd5bb2;
            this.ProductPictureBox.Location = new System.Drawing.Point(193, 226);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(346, 392);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPictureBox.TabIndex = 10;
            this.ProductPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(475, 624);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Like_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Minecraft 1.1", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Lavender;
            this.BtnLogin.Location = new System.Drawing.Point(193, 624);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(276, 68);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "В корзину";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // Products
            // 
            this.Products.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.Products.AllowDrop = true;
            this.Products.BackColor = System.Drawing.Color.Black;
            this.Products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Products.Font = new System.Drawing.Font("SkogenSpelFont", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.Color.Lavender;
            this.Products.FullRowSelect = true;
            this.Products.HideSelection = false;
            this.Products.Location = new System.Drawing.Point(636, 206);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(469, 499);
            this.Products.TabIndex = 3;
            this.Products.TileSize = new System.Drawing.Size(425, 100);
            this.Products.UseCompatibleStateImageBehavior = false;
            this.Products.View = System.Windows.Forms.View.Tile;
            // 
            // LogInBtn
            // 
            this.LogInBtn.Image = global::Db3.Properties.Resources._10131923_login_half_circle_line_icon;
            this.LogInBtn.InitialImage = null;
            this.LogInBtn.Location = new System.Drawing.Point(1111, 117);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(50, 50);
            this.LogInBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogInBtn.TabIndex = 2;
            this.LogInBtn.TabStop = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // LkBtn
            // 
            this.LkBtn.Image = global::Db3.Properties.Resources._1564534_customer_man_user_account_profile_icon;
            this.LkBtn.InitialImage = null;
            this.LkBtn.Location = new System.Drawing.Point(1055, 117);
            this.LkBtn.Name = "LkBtn";
            this.LkBtn.Size = new System.Drawing.Size(50, 50);
            this.LkBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LkBtn.TabIndex = 2;
            this.LkBtn.TabStop = false;
            this.LkBtn.Click += new System.EventHandler(this.LkBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFullScreen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 71);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Minecraft 1.1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Lavender;
            this.CloseButton.Location = new System.Drawing.Point(1166, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Minecraft 1.1", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretty Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFullScreen.Font = new System.Drawing.Font("Minecraft 1.1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFullScreen.ForeColor = System.Drawing.Color.Lavender;
            this.btnFullScreen.Location = new System.Drawing.Point(10, 10);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(150, 40);
            this.btnFullScreen.TabIndex = 0;
            this.btnFullScreen.Text = "Full Screen";
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        
        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Products;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        public System.Windows.Forms.Panel main;
        private System.Windows.Forms.Label CartBtn;
        private System.Windows.Forms.Label Orders;
        private System.Windows.Forms.Label LikedBtn;
        private System.Windows.Forms.PictureBox LogInBtn;
        private System.Windows.Forms.PictureBox LkBtn;
        private Button btnFullScreen;
    }
}