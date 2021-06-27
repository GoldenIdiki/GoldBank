
namespace GoldBankLite.UI_BankForms
{
    partial class Balance
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
            this.Balance_Header = new System.Windows.Forms.Panel();
            this.Balance_BalanceNotification = new System.Windows.Forms.Label();
            this.Balance_ShowBalance = new System.Windows.Forms.Label();
            this.Balance_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Balance_Header
            // 
            this.Balance_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Balance_Header.Controls.Add(this.Balance_BalanceNotification);
            this.Balance_Header.Location = new System.Drawing.Point(-1, -1);
            this.Balance_Header.Name = "Balance_Header";
            this.Balance_Header.Size = new System.Drawing.Size(805, 135);
            this.Balance_Header.TabIndex = 0;
            // 
            // Balance_BalanceNotification
            // 
            this.Balance_BalanceNotification.AutoSize = true;
            this.Balance_BalanceNotification.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Balance_BalanceNotification.Location = new System.Drawing.Point(140, 39);
            this.Balance_BalanceNotification.Name = "Balance_BalanceNotification";
            this.Balance_BalanceNotification.Size = new System.Drawing.Size(467, 57);
            this.Balance_BalanceNotification.TabIndex = 1;
            this.Balance_BalanceNotification.Text = "ACCOUNT BALANCE";
            // 
            // Balance_ShowBalance
            // 
            this.Balance_ShowBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Balance_ShowBalance.Font = new System.Drawing.Font("Sitka Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Balance_ShowBalance.Location = new System.Drawing.Point(-1, 304);
            this.Balance_ShowBalance.Name = "Balance_ShowBalance";
            this.Balance_ShowBalance.Size = new System.Drawing.Size(805, 128);
            this.Balance_ShowBalance.TabIndex = 1;
            this.Balance_ShowBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 693);
            this.Controls.Add(this.Balance_ShowBalance);
            this.Controls.Add(this.Balance_Header);
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.Balance_Header.ResumeLayout(false);
            this.Balance_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Balance_Header;
        private System.Windows.Forms.Label Balance_BalanceNotification;
        private System.Windows.Forms.Label Balance_ShowBalance;
    }
}