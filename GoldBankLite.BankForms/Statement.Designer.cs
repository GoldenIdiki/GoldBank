
namespace GoldBankLite.UI_BankForms
{
    partial class Statement
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
            this.Balance_BalanceNotification = new System.Windows.Forms.Label();
            this.Balance_Header = new System.Windows.Forms.Panel();
            this.Statement_DashBoard = new System.Windows.Forms.Button();
            this.TransactHist = new System.Windows.Forms.DataGridView();
            this.Balance_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactHist)).BeginInit();
            this.SuspendLayout();
            // 
            // Balance_BalanceNotification
            // 
            this.Balance_BalanceNotification.AutoSize = true;
            this.Balance_BalanceNotification.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Balance_BalanceNotification.Location = new System.Drawing.Point(157, 36);
            this.Balance_BalanceNotification.Name = "Balance_BalanceNotification";
            this.Balance_BalanceNotification.Size = new System.Drawing.Size(605, 57);
            this.Balance_BalanceNotification.TabIndex = 1;
            this.Balance_BalanceNotification.Text = "STATEMENT OF ACCOUNT";
            // 
            // Balance_Header
            // 
            this.Balance_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Balance_Header.Controls.Add(this.Statement_DashBoard);
            this.Balance_Header.Controls.Add(this.Balance_BalanceNotification);
            this.Balance_Header.Location = new System.Drawing.Point(-2, -2);
            this.Balance_Header.Name = "Balance_Header";
            this.Balance_Header.Size = new System.Drawing.Size(1142, 135);
            this.Balance_Header.TabIndex = 2;
            // 
            // Statement_DashBoard
            // 
            this.Statement_DashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Statement_DashBoard.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Statement_DashBoard.Location = new System.Drawing.Point(859, 31);
            this.Statement_DashBoard.Name = "Statement_DashBoard";
            this.Statement_DashBoard.Size = new System.Drawing.Size(251, 75);
            this.Statement_DashBoard.TabIndex = 2;
            this.Statement_DashBoard.Text = "Back to DashBoard";
            this.Statement_DashBoard.UseVisualStyleBackColor = false;
            // 
            // TransactHist
            // 
            this.TransactHist.AllowUserToAddRows = false;
            this.TransactHist.AllowUserToDeleteRows = false;
            this.TransactHist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TransactHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactHist.Location = new System.Drawing.Point(-2, 130);
            this.TransactHist.Name = "TransactHist";
            this.TransactHist.ReadOnly = true;
            this.TransactHist.RowHeadersWidth = 62;
            this.TransactHist.RowTemplate.Height = 33;
            this.TransactHist.Size = new System.Drawing.Size(1142, 571);
            this.TransactHist.TabIndex = 3;
            // 
            // Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1135, 698);
            this.Controls.Add(this.TransactHist);
            this.Controls.Add(this.Balance_Header);
            this.Name = "Statement";
            this.Text = "Statement";
            this.Load += new System.EventHandler(this.Statement_Load);
            this.Balance_Header.ResumeLayout(false);
            this.Balance_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactHist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Balance_BalanceNotification;
        private System.Windows.Forms.Panel Balance_Header;
        private System.Windows.Forms.Button Statement_DashBoard;
        private System.Windows.Forms.DataGridView TransactHist;
    }
}