
namespace CryptoWallet
{
    partial class HomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNamelabel = new System.Windows.Forms.Label();
            this.debitTextBox = new System.Windows.Forms.TextBox();
            this.cryptoTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debit Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crypto Balance";
            // 
            // userNamelabel
            // 
            this.userNamelabel.AutoSize = true;
            this.userNamelabel.Location = new System.Drawing.Point(323, 32);
            this.userNamelabel.Name = "userNamelabel";
            this.userNamelabel.Size = new System.Drawing.Size(81, 17);
            this.userNamelabel.TabIndex = 3;
            this.userNamelabel.Text = "(username)";
            // 
            // debitTextBox
            // 
            this.debitTextBox.Location = new System.Drawing.Point(145, 79);
            this.debitTextBox.Name = "debitTextBox";
            this.debitTextBox.Size = new System.Drawing.Size(100, 22);
            this.debitTextBox.TabIndex = 4;
            // 
            // cryptoTextBox
            // 
            this.cryptoTextBox.Location = new System.Drawing.Point(145, 119);
            this.cryptoTextBox.Name = "cryptoTextBox";
            this.cryptoTextBox.Size = new System.Drawing.Size(100, 22);
            this.cryptoTextBox.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.actionsToolStripMenuItem,
            this.currenciesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 32);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withdrawToolStripMenuItem,
            this.depositToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(72, 28);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.depositToolStripMenuItem.Text = "Deposit";
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.transferToolStripMenuItem.Text = "Transfer";
            // 
            // currenciesToolStripMenuItem
            // 
            this.currenciesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xCurrencyToolStripMenuItem,
            this.yCurrencyToolStripMenuItem,
            this.zCurrencyToolStripMenuItem});
            this.currenciesToolStripMenuItem.Name = "currenciesToolStripMenuItem";
            this.currenciesToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            this.currenciesToolStripMenuItem.Text = "Currencies";
            // 
            // xCurrencyToolStripMenuItem
            // 
            this.xCurrencyToolStripMenuItem.Name = "xCurrencyToolStripMenuItem";
            this.xCurrencyToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.xCurrencyToolStripMenuItem.Text = "X Currency";
            // 
            // yCurrencyToolStripMenuItem
            // 
            this.yCurrencyToolStripMenuItem.Name = "yCurrencyToolStripMenuItem";
            this.yCurrencyToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.yCurrencyToolStripMenuItem.Text = "Y Currency";
            // 
            // zCurrencyToolStripMenuItem
            // 
            this.zCurrencyToolStripMenuItem.Name = "zCurrencyToolStripMenuItem";
            this.zCurrencyToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.zCurrencyToolStripMenuItem.Text = "Z Currency";
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(317, 360);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(86, 33);
            this.signOutButton.TabIndex = 7;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buy More";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(152, 178);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(93, 33);
            this.sellButton.TabIndex = 9;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Home Page";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.cryptoTextBox);
            this.Controls.Add(this.debitTextBox);
            this.Controls.Add(this.userNamelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userNamelabel;
        private System.Windows.Forms.TextBox debitTextBox;
        private System.Windows.Forms.TextBox cryptoTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currenciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xCurrencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yCurrencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zCurrencyToolStripMenuItem;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label label3;
    }
}