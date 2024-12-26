using System;

namespace Db3
{
    partial class OrderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.finalPriceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PaymentBox = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.finalPriceLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PaymentBox);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.OrderBtn);
            this.panel1.Controls.Add(this.Order);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 805);
            this.panel1.TabIndex = 2;
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressBox.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold);
            this.addressBox.ForeColor = System.Drawing.Color.Lavender;
            this.addressBox.Location = new System.Drawing.Point(865, 240);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(216, 46);
            this.addressBox.TabIndex = 27;
            // 
            // finalPriceLabel
            // 
            this.finalPriceLabel.AutoSize = true;
            this.finalPriceLabel.Font = new System.Drawing.Font("Minecraft 1.1", 14.25F, System.Drawing.FontStyle.Bold);
            this.finalPriceLabel.ForeColor = System.Drawing.Color.Lavender;
            this.finalPriceLabel.Location = new System.Drawing.Point(974, 414);
            this.finalPriceLabel.Name = "finalPriceLabel";
            this.finalPriceLabel.Size = new System.Drawing.Size(67, 23);
            this.finalPriceLabel.TabIndex = 25;
            this.finalPriceLabel.Text = "final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Lavender;
            this.label5.Location = new System.Drawing.Point(92, 600);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 24;
            // 
            // PaymentBox
            // 
            this.PaymentBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.PaymentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentBox.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold);
            this.PaymentBox.ForeColor = System.Drawing.Color.Lavender;
            this.PaymentBox.FormattingEnabled = true;
            this.PaymentBox.Items.AddRange(new object[] {
            "Наличными",
            "Картой при получении"});
            this.PaymentBox.Location = new System.Drawing.Point(865, 326);
            this.PaymentBox.Name = "PaymentBox";
            this.PaymentBox.Size = new System.Drawing.Size(216, 42);
            this.PaymentBox.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.Lavender;
            this.checkBox1.Location = new System.Drawing.Point(703, 475);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(371, 73);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Согласен с условиями использования сервисов PrettyShop и обработки персональных д" +
    "анных";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minecraft 1.1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(121, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Вернуться в корзину";
            this.label4.Click += new System.EventHandler(this.Cart_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Minecraft 1.1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(699, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 47);
            this.label3.TabIndex = 15;
            this.label3.Text = "Способ оплаты";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Minecraft 1.1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(699, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Адрес доставки";
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.OrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.OrderBtn.FlatAppearance.BorderSize = 0;
            this.OrderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.OrderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Minecraft 1.1", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderBtn.ForeColor = System.Drawing.Color.Lavender;
            this.OrderBtn.Location = new System.Drawing.Point(703, 554);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(371, 70);
            this.OrderBtn.TabIndex = 9;
            this.OrderBtn.Text = "To order";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // Order
            // 
            this.Order.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.Order.BackColor = System.Drawing.Color.Black;
            this.Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Order.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.Order.Font = new System.Drawing.Font("SkogenSpelFont", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.ForeColor = System.Drawing.Color.Lavender;
            this.Order.FullRowSelect = true;
            this.Order.HideSelection = false;
            this.Order.Location = new System.Drawing.Point(125, 234);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(505, 314);
            this.Order.TabIndex = 7;
            this.Order.UseCompatibleStateImageBehavior = false;
            this.Order.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 71);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
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
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Minecraft 1.1", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1202, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформление заказа";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minecraft 1.1", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(703, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "К оплате: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Minecraft 1.1", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Lavender;
            this.label7.Location = new System.Drawing.Point(1047, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 43);
            this.label7.TabIndex = 29;
            this.label7.Text = "₽";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Order;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox PaymentBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressBox;
        public System.Windows.Forms.Label finalPriceLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}