
namespace GoldBankLite.UI_BankForms
{
    partial class Login
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
            this.Login_Header = new System.Windows.Forms.Panel();
            this.Login_Title = new System.Windows.Forms.Label();
            this.Login_Email = new System.Windows.Forms.Label();
            this.Login_Email_Field = new System.Windows.Forms.TextBox();
            this.Login_Password = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Login_Password_Field = new System.Windows.Forms.MaskedTextBox();
            this.Login_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Header
            // 
            this.Login_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Login_Header.Controls.Add(this.Login_Title);
            this.Login_Header.Location = new System.Drawing.Point(-2, 1);
            this.Login_Header.Name = "Login_Header";
            this.Login_Header.Size = new System.Drawing.Size(805, 85);
            this.Login_Header.TabIndex = 0;
            // 
            // Login_Title
            // 
            this.Login_Title.AutoSize = true;
            this.Login_Title.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Login_Title.Location = new System.Drawing.Point(103, 21);
            this.Login_Title.Name = "Login_Title";
            this.Login_Title.Size = new System.Drawing.Size(532, 37);
            this.Login_Title.TabIndex = 1;
            this.Login_Title.Text = "GOLDBANKLITE LOVES YOU";
            // 
            // Login_Email
            // 
            this.Login_Email.AutoSize = true;
            this.Login_Email.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_Email.Location = new System.Drawing.Point(88, 225);
            this.Login_Email.Name = "Login_Email";
            this.Login_Email.Size = new System.Drawing.Size(85, 40);
            this.Login_Email.TabIndex = 1;
            this.Login_Email.Text = "Email";
            // 
            // Login_Email_Field
            // 
            this.Login_Email_Field.Location = new System.Drawing.Point(301, 185);
            this.Login_Email_Field.Multiline = true;
            this.Login_Email_Field.Name = "Login_Email_Field";
            this.Login_Email_Field.Size = new System.Drawing.Size(384, 80);
            this.Login_Email_Field.TabIndex = 2;
            // 
            // Login_Password
            // 
            this.Login_Password.AutoSize = true;
            this.Login_Password.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_Password.Location = new System.Drawing.Point(88, 394);
            this.Login_Password.Name = "Login_Password";
            this.Login_Password.Size = new System.Drawing.Size(130, 40);
            this.Login_Password.TabIndex = 3;
            this.Login_Password.Text = "Password";
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Login_Button.Font = new System.Drawing.Font("Sitka Display", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_Button.Location = new System.Drawing.Point(301, 523);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(189, 107);
            this.Login_Button.TabIndex = 5;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Login_Password_Field
            // 
            this.Login_Password_Field.Location = new System.Drawing.Point(301, 403);
            this.Login_Password_Field.Name = "Login_Password_Field";
            this.Login_Password_Field.PasswordChar = '*';
            this.Login_Password_Field.Size = new System.Drawing.Size(384, 31);
            this.Login_Password_Field.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.Login_Password_Field);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Login_Password);
            this.Controls.Add(this.Login_Email_Field);
            this.Controls.Add(this.Login_Email);
            this.Controls.Add(this.Login_Header);
            this.Name = "Login";
            this.Text = "Login";
            this.Login_Header.ResumeLayout(false);
            this.Login_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Login_Header;
        private System.Windows.Forms.Label Login_Title;
        private System.Windows.Forms.Label Login_Email;
        private System.Windows.Forms.TextBox Login_Email_Field;
        private System.Windows.Forms.Label Login_Password;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.MaskedTextBox Login_Password_Field;
    }
}