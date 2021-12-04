
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
            this.withdawAmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.transitNumberTextBox = new System.Windows.Forms.TextBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Are the following information correct?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Withdrawal amount:";
            // 
            // withdawAmountTextBox
            // 
            this.withdawAmountTextBox.Location = new System.Drawing.Point(75, 202);
            this.withdawAmountTextBox.Name = "withdawAmountTextBox";
            this.withdawAmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.withdawAmountTextBox.TabIndex = 3;
            this.withdawAmountTextBox.TextChanged += new System.EventHandler(this.withdawAmountTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "To:";
            // 
            // transitNumberTextBox
            // 
            this.transitNumberTextBox.Location = new System.Drawing.Point(75, 272);
            this.transitNumberTextBox.Name = "transitNumberTextBox";
            this.transitNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.transitNumberTextBox.TabIndex = 5;
            this.transitNumberTextBox.TextChanged += new System.EventHandler(this.transitNumberTextBox_TextChanged);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(69, 351);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(84, 35);
            this.withdrawButton.TabIndex = 6;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(261, 351);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 35);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ConfirmWithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 460);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.transitNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.withdawAmountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmWithdrawForm";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox withdawAmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox transitNumberTextBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button exitButton;
    }
}