
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
            this.label1 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.displayPriceButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Currency:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(170, 89);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(121, 22);
            this.amountTextBox.TabIndex = 1;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Items.AddRange(new object[] {
            "X Currency",
            "Y Currency",
            "Z Currency"});
            this.currencyComboBox.Location = new System.Drawing.Point(170, 57);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(121, 24);
            this.currencyComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Amount:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(286, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 17);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "(username)";
            // 
            // displayPriceButton
            // 
            this.displayPriceButton.Location = new System.Drawing.Point(46, 140);
            this.displayPriceButton.Name = "displayPriceButton";
            this.displayPriceButton.Size = new System.Drawing.Size(95, 44);
            this.displayPriceButton.TabIndex = 5;
            this.displayPriceButton.Text = "Display Price";
            this.displayPriceButton.UseVisualStyleBackColor = true;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(196, 140);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(95, 44);
            this.buyButton.TabIndex = 6;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(250, 283);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 44);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buy";
            // 
            // BuyMoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 379);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.displayPriceButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currencyComboBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BuyMoreForm";
            this.Text = "Buy:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button displayPriceButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
    }
}