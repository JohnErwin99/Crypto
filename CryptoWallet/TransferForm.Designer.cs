
namespace CryptoWallet
{
    partial class TransferForm
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
            this.transferLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transferLabel
            // 
            this.transferLabel.AutoSize = true;
            this.transferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferLabel.Location = new System.Drawing.Point(60, 37);
            this.transferLabel.Name = "transferLabel";
            this.transferLabel.Size = new System.Drawing.Size(142, 36);
            this.transferLabel.TabIndex = 0;
            this.transferLabel.Text = "Transfer:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(53, 105);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(234, 17);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Enter the amount you wish to send: ";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(460, 102);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(272, 22);
            this.amountTextBox.TabIndex = 2;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the email address of the person you are sendinng to:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(460, 171);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(272, 22);
            this.emailTextBox.TabIndex = 4;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(232, 265);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(92, 33);
            this.continueButton.TabIndex = 5;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(460, 265);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 33);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 381);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.transferLabel);
            this.Name = "TransferForm";
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transferLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button cancelButton;
    }
}