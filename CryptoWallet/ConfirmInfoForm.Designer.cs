
namespace CryptoWallet
{
    partial class ConfirmInfoForm
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
            this.confirmLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.receiverTxtBox = new System.Windows.Forms.Label();
            this.sendingAmountTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.Location = new System.Drawing.Point(54, 55);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(197, 32);
            this.confirmLabel.TabIndex = 0;
            this.confirmLabel.Text = "Confirmation:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Are the following informations correct?";
            // 
            // sendLabel
            // 
            this.sendLabel.AutoSize = true;
            this.sendLabel.Location = new System.Drawing.Point(66, 226);
            this.sendLabel.Name = "sendLabel";
            this.sendLabel.Size = new System.Drawing.Size(51, 20);
            this.sendLabel.TabIndex = 2;
            this.sendLabel.Text = "Send:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(66, 309);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(31, 20);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To:";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(70, 416);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(88, 36);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(309, 416);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 36);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // receiverTxtBox
            // 
            this.receiverTxtBox.AutoSize = true;
            this.receiverTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiverTxtBox.Location = new System.Drawing.Point(78, 348);
            this.receiverTxtBox.Name = "receiverTxtBox";
            this.receiverTxtBox.Size = new System.Drawing.Size(19, 26);
            this.receiverTxtBox.TabIndex = 11;
            this.receiverTxtBox.Text = " ";
            // 
            // sendingAmountTextBox
            // 
            this.sendingAmountTextBox.AutoSize = true;
            this.sendingAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendingAmountTextBox.Location = new System.Drawing.Point(78, 257);
            this.sendingAmountTextBox.Name = "sendingAmountTextBox";
            this.sendingAmountTextBox.Size = new System.Drawing.Size(19, 26);
            this.sendingAmountTextBox.TabIndex = 10;
            this.sendingAmountTextBox.Text = " ";
            // 
            // ConfirmInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 527);
            this.Controls.Add(this.receiverTxtBox);
            this.Controls.Add(this.sendingAmountTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.sendLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConfirmInfoForm";
            this.Text = "ConfirmInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sendLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label receiverTxtBox;
        private System.Windows.Forms.Label sendingAmountTextBox;
    }
}