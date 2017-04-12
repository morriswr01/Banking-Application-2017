namespace BankingApplicationProgram
{
    partial class LoginForm
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
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.rb_CreateUsrAccount = new System.Windows.Forms.RadioButton();
            this.rb_Existing = new System.Windows.Forms.RadioButton();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Verdana", 14F);
            this.lbl_Username.ForeColor = System.Drawing.Color.White;
            this.lbl_Username.Location = new System.Drawing.Point(324, 170);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(105, 23);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Verdana", 14F);
            this.lbl_Password.ForeColor = System.Drawing.Color.White;
            this.lbl_Password.Location = new System.Drawing.Point(324, 232);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(100, 23);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Verdana", 14F);
            this.tb_Username.Location = new System.Drawing.Point(533, 167);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(100, 30);
            this.tb_Username.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Verdana", 14F);
            this.tb_Password.Location = new System.Drawing.Point(533, 229);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(100, 30);
            this.tb_Password.TabIndex = 3;
            // 
            // rb_CreateUsrAccount
            // 
            this.rb_CreateUsrAccount.AutoSize = true;
            this.rb_CreateUsrAccount.Font = new System.Drawing.Font("Verdana", 10F);
            this.rb_CreateUsrAccount.ForeColor = System.Drawing.Color.White;
            this.rb_CreateUsrAccount.Location = new System.Drawing.Point(533, 105);
            this.rb_CreateUsrAccount.Name = "rb_CreateUsrAccount";
            this.rb_CreateUsrAccount.Size = new System.Drawing.Size(168, 21);
            this.rb_CreateUsrAccount.TabIndex = 4;
            this.rb_CreateUsrAccount.Text = "Create New Account";
            this.rb_CreateUsrAccount.UseVisualStyleBackColor = true;
            this.rb_CreateUsrAccount.CheckedChanged += new System.EventHandler(this.NewUser_Selected);
            // 
            // rb_Existing
            // 
            this.rb_Existing.AutoSize = true;
            this.rb_Existing.Checked = true;
            this.rb_Existing.Font = new System.Drawing.Font("Verdana", 10F);
            this.rb_Existing.ForeColor = System.Drawing.Color.White;
            this.rb_Existing.Location = new System.Drawing.Point(324, 105);
            this.rb_Existing.Name = "rb_Existing";
            this.rb_Existing.Size = new System.Drawing.Size(119, 21);
            this.rb_Existing.TabIndex = 5;
            this.rb_Existing.TabStop = true;
            this.rb_Existing.Text = "Existing User";
            this.rb_Existing.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(25)))));
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(443, 354);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(100, 30);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(372, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Banking Application Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.rb_Existing);
            this.Controls.Add(this.rb_CreateUsrAccount);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "LoginForm";
            this.Text = "Existing Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.RadioButton rb_CreateUsrAccount;
        private System.Windows.Forms.RadioButton rb_Existing;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label1;
    }
}

