namespace BankingApplicationProgram
{
    partial class PostLoginScreen
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
            this.tb_welcomeBanner = new System.Windows.Forms.Label();
            this.btn_ViewExistingAccount = new System.Windows.Forms.Button();
            this.btn_AddExistingAccount = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_CreateNewAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_welcomeBanner
            // 
            this.tb_welcomeBanner.AutoSize = true;
            this.tb_welcomeBanner.Font = new System.Drawing.Font("Verdana", 16F);
            this.tb_welcomeBanner.ForeColor = System.Drawing.Color.White;
            this.tb_welcomeBanner.Location = new System.Drawing.Point(370, 34);
            this.tb_welcomeBanner.Name = "tb_welcomeBanner";
            this.tb_welcomeBanner.Size = new System.Drawing.Size(230, 26);
            this.tb_welcomeBanner.TabIndex = 0;
            this.tb_welcomeBanner.Text = "Banking Application";
            this.tb_welcomeBanner.Click += new System.EventHandler(this.tb_welcomeBanner_Click);
            // 
            // btn_ViewExistingAccount
            // 
            this.btn_ViewExistingAccount.Font = new System.Drawing.Font("Verdana", 18F);
            this.btn_ViewExistingAccount.Location = new System.Drawing.Point(332, 159);
            this.btn_ViewExistingAccount.Name = "btn_ViewExistingAccount";
            this.btn_ViewExistingAccount.Size = new System.Drawing.Size(287, 65);
            this.btn_ViewExistingAccount.TabIndex = 3;
            this.btn_ViewExistingAccount.Text = "View Existing Account";
            this.btn_ViewExistingAccount.UseVisualStyleBackColor = true;
            this.btn_ViewExistingAccount.Click += new System.EventHandler(this.ViewExistingAccountBtn_Click);
            // 
            // btn_AddExistingAccount
            // 
            this.btn_AddExistingAccount.Font = new System.Drawing.Font("Verdana", 18F);
            this.btn_AddExistingAccount.Location = new System.Drawing.Point(332, 230);
            this.btn_AddExistingAccount.Name = "btn_AddExistingAccount";
            this.btn_AddExistingAccount.Size = new System.Drawing.Size(287, 65);
            this.btn_AddExistingAccount.TabIndex = 4;
            this.btn_AddExistingAccount.Text = "Add Existing Account";
            this.btn_AddExistingAccount.UseVisualStyleBackColor = true;
            this.btn_AddExistingAccount.Click += new System.EventHandler(this.btn_AddExistingAccount_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 12F);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(872, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(12, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_CreateNewAccount
            // 
            this.btn_CreateNewAccount.Font = new System.Drawing.Font("Verdana", 18F);
            this.btn_CreateNewAccount.Location = new System.Drawing.Point(332, 301);
            this.btn_CreateNewAccount.Name = "btn_CreateNewAccount";
            this.btn_CreateNewAccount.Size = new System.Drawing.Size(287, 65);
            this.btn_CreateNewAccount.TabIndex = 12;
            this.btn_CreateNewAccount.Text = "Create New Account";
            this.btn_CreateNewAccount.UseVisualStyleBackColor = true;
            this.btn_CreateNewAccount.Click += new System.EventHandler(this.btn_CreateNewAccount_Click);
            // 
            // PostLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btn_CreateNewAccount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_AddExistingAccount);
            this.Controls.Add(this.btn_ViewExistingAccount);
            this.Controls.Add(this.tb_welcomeBanner);
            this.Name = "PostLoginScreen";
            this.Text = "Options Screen";
            this.Load += new System.EventHandler(this.PostLoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tb_welcomeBanner;
        private System.Windows.Forms.Button btn_ViewExistingAccount;
        private System.Windows.Forms.Button btn_AddExistingAccount;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_CreateNewAccount;
    }
}