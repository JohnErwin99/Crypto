
namespace CryptoWallet
{
    partial class BuyMoreForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ads = new System.Windows.Forms.Panel();
            this.priceBtn = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cryptoNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.previousBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ads.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Currency:";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(501, 73);
            this.qtyTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(92, 20);
            this.qtyTextBox.TabIndex = 1;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Items.AddRange(new object[] {
            "CAN",
            "USD",
            "EURO"});
            this.currencyComboBox.Location = new System.Drawing.Point(501, 47);
            this.currencyComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(92, 21);
            this.currencyComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(599, 6);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(59, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "(username)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buy";
            // 
            // Ads
            // 
            this.Ads.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ads.Controls.Add(this.priceBtn);
            this.Ads.Controls.Add(this.buyBtn);
            this.Ads.Controls.Add(this.panel1);
            this.Ads.Controls.Add(this.label2);
            this.Ads.Controls.Add(this.label1);
            this.Ads.Controls.Add(this.currencyComboBox);
            this.Ads.Controls.Add(this.qtyTextBox);
            this.Ads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ads.Location = new System.Drawing.Point(0, 0);
            this.Ads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ads.Name = "Ads";
            this.Ads.Size = new System.Drawing.Size(667, 379);
            this.Ads.TabIndex = 17;
            // 
            // priceBtn
            // 
            this.priceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.priceBtn.Location = new System.Drawing.Point(347, 331);
            this.priceBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceBtn.Name = "priceBtn";
            this.priceBtn.Size = new System.Drawing.Size(71, 29);
            this.priceBtn.TabIndex = 13;
            this.priceBtn.Text = "Check Price";
            this.priceBtn.UseVisualStyleBackColor = false;
            this.priceBtn.Click += new System.EventHandler(this.priceBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buyBtn.Location = new System.Drawing.Point(501, 105);
            this.buyBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(91, 36);
            this.buyBtn.TabIndex = 12;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = false;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.cryptoNameLbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.previousBtn);
            this.panel1.Controls.Add(this.NextBtn);
            this.panel1.Location = new System.Drawing.Point(17, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 346);
            this.panel1.TabIndex = 11;
            // 
            // cryptoNameLbl
            // 
            this.cryptoNameLbl.AutoSize = true;
            this.cryptoNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cryptoNameLbl.Location = new System.Drawing.Point(127, 296);
            this.cryptoNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cryptoNameLbl.Name = "cryptoNameLbl";
            this.cryptoNameLbl.Size = new System.Drawing.Size(51, 20);
            this.cryptoNameLbl.TabIndex = 12;
            this.cryptoNameLbl.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(15, 296);
            this.previousBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(69, 25);
            this.previousBtn.TabIndex = 8;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(235, 298);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(67, 23);
            this.NextBtn.TabIndex = 9;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(CryptoWallet.Inventory);
            // 
            // BuyMoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 379);
            this.Controls.Add(this.Ads);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BuyMoreForm";
            this.Text = "Buy:";
            this.Ads.ResumeLayout(false);
            this.Ads.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Ads;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.Label cryptoNameLbl;
        private System.Windows.Forms.Button priceBtn;
    }
}