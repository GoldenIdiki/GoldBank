
namespace GoldBankLite.UI_BankForms
{
    partial class DashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DashBoard_Logout = new System.Windows.Forms.Button();
            this.DashBoard_Statement = new System.Windows.Forms.Button();
            this.DashBoard_Balance = new System.Windows.Forms.Button();
            this.DashBoard_Transfer = new System.Windows.Forms.Button();
            this.DashBoard_Withdraw = new System.Windows.Forms.Button();
            this.DashBoard_Deposit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.DashBoard_Logout);
            this.panel1.Controls.Add(this.DashBoard_Statement);
            this.panel1.Controls.Add(this.DashBoard_Balance);
            this.panel1.Controls.Add(this.DashBoard_Transfer);
            this.panel1.Controls.Add(this.DashBoard_Withdraw);
            this.panel1.Controls.Add(this.DashBoard_Deposit);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 704);
            this.panel1.TabIndex = 0;
            // 
            // DashBoard_Logout
            // 
            this.DashBoard_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DashBoard_Logout.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashBoard_Logout.Location = new System.Drawing.Point(0, 591);
            this.DashBoard_Logout.Name = "DashBoard_Logout";
            this.DashBoard_Logout.Size = new System.Drawing.Size(228, 64);
            this.DashBoard_Logout.TabIndex = 1;
            this.DashBoard_Logout.Text = "Logout";
            this.DashBoard_Logout.UseVisualStyleBackColor = false;
            // 
            // DashBoard_Statement
            // 
            this.DashBoard_Statement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DashBoard_Statement.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashBoard_Statement.Location = new System.Drawing.Point(0, 487);
            this.DashBoard_Statement.Name = "DashBoard_Statement";
            this.DashBoard_Statement.Size = new System.Drawing.Size(226, 67);
            this.DashBoard_Statement.TabIndex = 1;
            this.DashBoard_Statement.Text = "Statement";
            this.DashBoard_Statement.UseVisualStyleBackColor = false;
            this.DashBoard_Statement.Click += new System.EventHandler(this.DashBoard_Statement_Click);
            // 
            // DashBoard_Balance
            // 
            this.DashBoard_Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DashBoard_Balance.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashBoard_Balance.Location = new System.Drawing.Point(0, 384);
            this.DashBoard_Balance.Name = "DashBoard_Balance";
            this.DashBoard_Balance.Size = new System.Drawing.Size(226, 68);
            this.DashBoard_Balance.TabIndex = 1;
            this.DashBoard_Balance.Text = "Balance";
            this.DashBoard_Balance.UseVisualStyleBackColor = false;
            this.DashBoard_Balance.Click += new System.EventHandler(this.DashBoard_Balance_Click);
            // 
            // DashBoard_Transfer
            // 
            this.DashBoard_Transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DashBoard_Transfer.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashBoard_Transfer.Location = new System.Drawing.Point(0, 271);
            this.DashBoard_Transfer.Name = "DashBoard_Transfer";
            this.DashBoard_Transfer.Size = new System.Drawing.Size(228, 79);
            this.DashBoard_Transfer.TabIndex = 1;
            this.DashBoard_Transfer.Text = "Transfer";
            this.DashBoard_Transfer.UseVisualStyleBackColor = false;
            this.DashBoard_Transfer.Click += new System.EventHandler(this.DashBoard_Transfer_Click);
            // 
            // DashBoard_Withdraw
            // 
            this.DashBoard_Withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DashBoard_Withdraw.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashBoard_Withdraw.Location = new System.Drawing.Point(0, 162);
            this.DashBoard_Withdraw.Name = "DashBoard_Withdraw";
            this.DashBoard_Withdraw.Size = new System.Drawing.Size(228, 79);
            this.DashBoard_Withdraw.TabIndex = 1;
            this.DashBoard_Withdraw.Text = "Withdraw";
            this.DashBoard_Withdraw.UseVisualStyleBackColor = false;
            this.DashBoard_Withdraw.Click += new System.EventHandler(this.DashBoard_Withdraw_Click);
            // 
            // DashBoard_Deposit
            // 
            this.DashBoard_Deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DashBoard_Deposit.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashBoard_Deposit.Location = new System.Drawing.Point(0, 53);
            this.DashBoard_Deposit.Name = "DashBoard_Deposit";
            this.DashBoard_Deposit.Size = new System.Drawing.Size(226, 75);
            this.DashBoard_Deposit.TabIndex = 1;
            this.DashBoard_Deposit.Text = "Deposit";
            this.DashBoard_Deposit.UseVisualStyleBackColor = false;
            this.DashBoard_Deposit.Click += new System.EventHandler(this.DashBoard_Deposit_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DashBoard_Logout;
        private System.Windows.Forms.Button DashBoard_Statement;
        private System.Windows.Forms.Button DashBoard_Balance;
        private System.Windows.Forms.Button DashBoard_Transfer;
        private System.Windows.Forms.Button DashBoard_Withdraw;
        private System.Windows.Forms.Button DashBoard_Deposit;
    }
}