
namespace CryptoWallet
{
    partial class ConfirmWithdrawForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.withdawAmountTextBox = new System.Windows.Forms.Label();
            this.transitNumberTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Are the following information correct?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Withdrawal amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "To:";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(78, 439);
            this.withdrawButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(94, 44);
            this.withdrawButton.TabIndex = 6;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(294, 439);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 44);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // withdawAmountTextBox
            // 
            this.withdawAmountTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.withdawAmountTextBox.AutoSize = true;
            this.withdawAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdawAmountTextBox.Location = new System.Drawing.Point(82, 245);
            this.withdawAmountTextBox.Name = "withdawAmountTextBox";
            this.withdawAmountTextBox.Size = new System.Drawing.Size(19, 26);
            this.withdawAmountTextBox.TabIndex = 8;
            this.withdawAmountTextBox.Text = " ";
            // 
            // transitNumberTextBox
            // 
            this.transitNumberTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.transitNumberTextBox.AutoSize = true;
            this.transitNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transitNumberTextBox.Location = new System.Drawing.Point(82, 341);
            this.transitNumberTextBox.Name = "transitNumberTextBox";
            this.transitNumberTextBox.Size = new System.Drawing.Size(19, 26);
            this.transitNumberTextBox.TabIndex = 9;
            this.transitNumberTextBox.Text = " ";
            // 
            // ConfirmWithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 564);
            this.Controls.Add(this.transitNumberTextBox);
            this.Controls.Add(this.withdawAmountTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConfirmWithdrawForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label withdawAmountTextBox;
        private System.Windows.Forms.Label transitNumberTextBox;
    }
}