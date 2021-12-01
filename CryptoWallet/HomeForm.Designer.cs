
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cryptoBalanceLabel;
            System.Windows.Forms.Label debitBalanceLabel;
            System.Windows.Forms.Label userIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.userNamelabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.label3 = new System.Windows.Forms.Label();
            this.Balances = new System.Windows.Forms.Panel();
            this.cryptoBalanceLabel1 = new System.Windows.Forms.Label();
            this.debitBalanceLabel1 = new System.Windows.Forms.Label();
            this.userIdLabel1 = new System.Windows.Forms.Label();
            this.bankingInformationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bankingInformationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ads = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bankingInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cryptoBalanceLabel = new System.Windows.Forms.Label();
            debitBalanceLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Balances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankingInformationBindingNavigator)).BeginInit();
            this.bankingInformationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Ads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cryptoBalanceLabel
            // 
            cryptoBalanceLabel.AutoSize = true;
            cryptoBalanceLabel.Location = new System.Drawing.Point(42, 31);
            cryptoBalanceLabel.Name = "cryptoBalanceLabel";
            cryptoBalanceLabel.Size = new System.Drawing.Size(121, 20);
            cryptoBalanceLabel.TabIndex = 0;
            cryptoBalanceLabel.Text = "Crypto Balance:";
            // 
            // debitBalanceLabel
            // 
            debitBalanceLabel.AutoSize = true;
            debitBalanceLabel.Location = new System.Drawing.Point(42, 54);
            debitBalanceLabel.Name = "debitBalanceLabel";
            debitBalanceLabel.Size = new System.Drawing.Size(113, 20);
            debitBalanceLabel.TabIndex = 2;
            debitBalanceLabel.Text = "Debit Balance:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(42, 77);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(65, 20);
            userIdLabel.TabIndex = 4;
            userIdLabel.Text = "User Id:";
            // 
            // userNamelabel
            // 
            this.userNamelabel.AutoSize = true;
            this.userNamelabel.Location = new System.Drawing.Point(147, 56);
            this.userNamelabel.Name = "userNamelabel";
            this.userNamelabel.Size = new System.Drawing.Size(90, 20);
            this.userNamelabel.TabIndex = 3;
            this.userNamelabel.Text = "(username)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.currenciesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(753, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withdrawToolStripMenuItem,
            this.depositToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // currenciesToolStripMenuItem
            // 
            this.currenciesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xCurrencyToolStripMenuItem,
            this.yCurrencyToolStripMenuItem,
            this.zCurrencyToolStripMenuItem});
            this.currenciesToolStripMenuItem.Name = "currenciesToolStripMenuItem";
            this.currenciesToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.currenciesToolStripMenuItem.Text = "Currencies";
            // 
            // xCurrencyToolStripMenuItem
            // 
            this.xCurrencyToolStripMenuItem.Name = "xCurrencyToolStripMenuItem";
            this.xCurrencyToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.xCurrencyToolStripMenuItem.Text = "X Currency";
            // 
            // yCurrencyToolStripMenuItem
            // 
            this.yCurrencyToolStripMenuItem.Name = "yCurrencyToolStripMenuItem";
            this.yCurrencyToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.yCurrencyToolStripMenuItem.Text = "Y Currency";
            // 
            // zCurrencyToolStripMenuItem
            // 
            this.zCurrencyToolStripMenuItem.Name = "zCurrencyToolStripMenuItem";
            this.zCurrencyToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.zCurrencyToolStripMenuItem.Text = "Z Currency";
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(357, 450);
            this.signOutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(97, 41);
            this.signOutButton.TabIndex = 7;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Welcome ";
            // 
            // Balances
            // 
            this.Balances.Controls.Add(cryptoBalanceLabel);
            this.Balances.Controls.Add(this.cryptoBalanceLabel1);
            this.Balances.Controls.Add(debitBalanceLabel);
            this.Balances.Controls.Add(this.debitBalanceLabel1);
            this.Balances.Controls.Add(userIdLabel);
            this.Balances.Controls.Add(this.userIdLabel1);
            this.Balances.Location = new System.Drawing.Point(426, 81);
            this.Balances.Name = "Balances";
            this.Balances.Size = new System.Drawing.Size(250, 156);
            this.Balances.TabIndex = 11;
            // 
            // cryptoBalanceLabel1
            // 
            this.cryptoBalanceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankingInformationBindingSource, "CryptoBalance", true));
            this.cryptoBalanceLabel1.Location = new System.Drawing.Point(169, 31);
            this.cryptoBalanceLabel1.Name = "cryptoBalanceLabel1";
            this.cryptoBalanceLabel1.Size = new System.Drawing.Size(100, 23);
            this.cryptoBalanceLabel1.TabIndex = 1;
            this.cryptoBalanceLabel1.Text = "label1";
            // 
            // debitBalanceLabel1
            // 
            this.debitBalanceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankingInformationBindingSource, "DebitBalance", true));
            this.debitBalanceLabel1.Location = new System.Drawing.Point(169, 54);
            this.debitBalanceLabel1.Name = "debitBalanceLabel1";
            this.debitBalanceLabel1.Size = new System.Drawing.Size(100, 23);
            this.debitBalanceLabel1.TabIndex = 3;
            this.debitBalanceLabel1.Text = "label1";
            // 
            // userIdLabel1
            // 
            this.userIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankingInformationBindingSource, "UserId", true));
            this.userIdLabel1.Location = new System.Drawing.Point(169, 77);
            this.userIdLabel1.Name = "userIdLabel1";
            this.userIdLabel1.Size = new System.Drawing.Size(100, 23);
            this.userIdLabel1.TabIndex = 5;
            this.userIdLabel1.Text = "label1";
            // 
            // bankingInformationBindingNavigator
            // 
            this.bankingInformationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bankingInformationBindingNavigator.BindingSource = this.bankingInformationBindingSource;
            this.bankingInformationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bankingInformationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bankingInformationBindingNavigator.Dock = System.Windows.Forms.DockStyle.Right;
            this.bankingInformationBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bankingInformationBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bankingInformationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bankingInformationBindingNavigatorSaveItem});
            this.bankingInformationBindingNavigator.Location = new System.Drawing.Point(697, 33);
            this.bankingInformationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bankingInformationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bankingInformationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bankingInformationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bankingInformationBindingNavigator.Name = "bankingInformationBindingNavigator";
            this.bankingInformationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bankingInformationBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bankingInformationBindingNavigator.Size = new System.Drawing.Size(56, 458);
            this.bankingInformationBindingNavigator.TabIndex = 12;
            this.bankingInformationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(51, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(51, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(51, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(51, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(51, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(51, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(51, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(51, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(51, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(51, 6);
            // 
            // bankingInformationBindingNavigatorSaveItem
            // 
            this.bankingInformationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bankingInformationBindingNavigatorSaveItem.Enabled = false;
            this.bankingInformationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bankingInformationBindingNavigatorSaveItem.Image")));
            this.bankingInformationBindingNavigatorSaveItem.Name = "bankingInformationBindingNavigatorSaveItem";
            this.bankingInformationBindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 28);
            this.bankingInformationBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Ads
            // 
            this.Ads.BackColor = System.Drawing.SystemColors.Info;
            this.Ads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ads.Controls.Add(this.label4);
            this.Ads.Controls.Add(this.label2);
            this.Ads.Controls.Add(this.pictureBox2);
            this.Ads.Controls.Add(this.label1);
            this.Ads.Controls.Add(this.button1);
            this.Ads.Controls.Add(this.pictureBox1);
            this.Ads.Location = new System.Drawing.Point(17, 81);
            this.Ads.Name = "Ads";
            this.Ads.Size = new System.Drawing.Size(375, 324);
            this.Ads.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Volatile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Trending";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(201, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 14;
            // 
            // bankingInformationBindingSource
            // 
            this.bankingInformationBindingSource.DataSource = typeof(CryptoWallet.BankingInformation);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 491);
            this.Controls.Add(this.Ads);
            this.Controls.Add(this.bankingInformationBindingNavigator);
            this.Controls.Add(this.Balances);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.userNamelabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Balances.ResumeLayout(false);
            this.Balances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankingInformationBindingNavigator)).EndInit();
            this.bankingInformationBindingNavigator.ResumeLayout(false);
            this.bankingInformationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Ads.ResumeLayout(false);
            this.Ads.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userNamelabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Balances;
        private System.Windows.Forms.Label cryptoBalanceLabel1;
        private System.Windows.Forms.BindingSource bankingInformationBindingSource;
        private System.Windows.Forms.Label debitBalanceLabel1;
        private System.Windows.Forms.Label userIdLabel1;
        private System.Windows.Forms.BindingNavigator bankingInformationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bankingInformationBindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Ads;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}