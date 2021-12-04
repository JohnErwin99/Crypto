
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
            this.sendingAmountTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.recieverTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.Location = new System.Drawing.Point(48, 44);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(168, 29);
            this.confirmLabel.TabIndex = 0;
            this.confirmLabel.Text = "Confirmation:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Are the following informations correct?";
            // 
            // sendLabel
            // 
            this.sendLabel.AutoSize = true;
            this.sendLabel.Location = new System.Drawing.Point(59, 181);
            this.sendLabel.Name = "sendLabel";
            this.sendLabel.Size = new System.Drawing.Size(45, 17);
            this.sendLabel.TabIndex = 2;
            this.sendLabel.Text = "Send:";
            // 
            // sendingAmountTextBox
            // 
            this.sendingAmountTextBox.Location = new System.Drawing.Point(59, 201);
            this.sendingAmountTextBox.Name = "sendingAmountTextBox";
            this.sendingAmountTextBox.Size = new System.Drawing.Size(189, 22);
            this.sendingAmountTextBox.TabIndex = 3;
            this.sendingAmountTextBox.TextChanged += new System.EventHandler(this.sendingAmountTextBox_TextChanged);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(59, 247);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(29, 17);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To:";
            // 
            // recieverTextBox
            // 
            this.recieverTextBox.Location = new System.Drawing.Point(62, 267);
            this.recieverTextBox.Name = "recieverTextBox";
            this.recieverTextBox.Size = new System.Drawing.Size(186, 22);
            this.recieverTextBox.TabIndex = 5;
            this.recieverTextBox.TextChanged += new System.EventHandler(this.recieverTextBox_TextChanged);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(62, 333);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(78, 29);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(275, 333);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(78, 29);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ConfirmInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 427);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.recieverTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.sendingAmountTextBox);
            this.Controls.Add(this.sendLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmLabel);
            this.Name = "ConfirmInfoForm";
            this.Text = "ConfirmInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sendLabel;
        private System.Windows.Forms.TextBox sendingAmountTextBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox recieverTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button cancelButton;
    }
}