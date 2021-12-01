
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
            this.buyBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cryptoNameLbl = new System.Windows.Forms.Label();
            this.previousBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceBtn = new System.Windows.Forms.Button();
            this.Ads.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Currency:";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(751, 113);
            this.qtyTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(136, 26);
            this.qtyTextBox.TabIndex = 1;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Items.AddRange(new object[] {
            "X Currency",
            "Y Currency",
            "Z Currency"});
            this.currencyComboBox.Location = new System.Drawing.Point(751, 73);
            this.currencyComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(136, 28);
            this.currencyComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(898, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(90, 20);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "(username)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
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
            this.Ads.Name = "Ads";
            this.Ads.Size = new System.Drawing.Size(1000, 583);
            this.Ads.TabIndex = 17;
            // 
            // buyBtn
            // 
            this.buyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buyBtn.Location = new System.Drawing.Point(751, 161);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(136, 55);
            this.buyBtn.TabIndex = 12;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.cryptoNameLbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.previousBtn);
            this.panel1.Controls.Add(this.NextBtn);
            this.panel1.Location = new System.Drawing.Point(25, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 532);
            this.panel1.TabIndex = 11;
            // 
            // cryptoNameLbl
            // 
            this.cryptoNameLbl.AutoSize = true;
            this.cryptoNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cryptoNameLbl.Location = new System.Drawing.Point(190, 455);
            this.cryptoNameLbl.Name = "cryptoNameLbl";
            this.cryptoNameLbl.Size = new System.Drawing.Size(79, 29);
            this.cryptoNameLbl.TabIndex = 12;
            this.cryptoNameLbl.Text = "label4";
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(23, 455);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(104, 39);
            this.previousBtn.TabIndex = 8;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(353, 458);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(101, 36);
            this.NextBtn.TabIndex = 9;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(CryptoWallet.Inventory);
            // 
            // priceBtn
            // 
            this.priceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.priceBtn.Location = new System.Drawing.Point(520, 509);
            this.priceBtn.Name = "priceBtn";
            this.priceBtn.Size = new System.Drawing.Size(107, 45);
            this.priceBtn.TabIndex = 13;
            this.priceBtn.Text = "Check Price";
            this.priceBtn.UseVisualStyleBackColor = false;
            this.priceBtn.Click += new System.EventHandler(this.priceBtn_Click);
            // 
            // BuyMoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 583);
            this.Controls.Add(this.Ads);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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