namespace BankingApplicationProgram
{
    partial class CreateNewAccount
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_welcomeBanner = new System.Windows.Forms.Label();
            this.cb_AccountType = new System.Windows.Forms.ComboBox();
            this.cb_SecurityQuestion = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_AccntNmbr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SecurityQAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(12, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 12F);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(872, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 12;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // tb_welcomeBanner
            // 
            this.tb_welcomeBanner.AutoSize = true;
            this.tb_welcomeBanner.Font = new System.Drawing.Font("Verdana", 16F);
            this.tb_welcomeBanner.ForeColor = System.Drawing.Color.White;
            this.tb_welcomeBanner.Location = new System.Drawing.Point(380, 26);
            this.tb_welcomeBanner.Name = "tb_welcomeBanner";
            this.tb_welcomeBanner.Size = new System.Drawing.Size(234, 26);
            this.tb_welcomeBanner.TabIndex = 14;
            this.tb_welcomeBanner.Text = "Create New Account";
            // 
            // cb_AccountType
            // 
            this.cb_AccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_AccountType.FormattingEnabled = true;
            this.cb_AccountType.Items.AddRange(new object[] {
            "Savings",
            "Investment",
            "ISA"});
            this.cb_AccountType.Location = new System.Drawing.Point(531, 109);
            this.cb_AccountType.Name = "cb_AccountType";
            this.cb_AccountType.Size = new System.Drawing.Size(150, 28);
            this.cb_AccountType.TabIndex = 15;
            // 
            // cb_SecurityQuestion
            // 
            this.cb_SecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_SecurityQuestion.FormattingEnabled = true;
            this.cb_SecurityQuestion.Items.AddRange(new object[] {
            "What is your mothers maiden name?",
            "What is the name of the street you grew up on?",
            "What was the name of your primary school?",
            "What was the name of your first pet?"});
            this.cb_SecurityQuestion.Location = new System.Drawing.Point(531, 146);
            this.cb_SecurityQuestion.Name = "cb_SecurityQuestion";
            this.cb_SecurityQuestion.Size = new System.Drawing.Size(429, 28);
            this.cb_SecurityQuestion.TabIndex = 16;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(25)))));
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(447, 326);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(100, 30);
            this.btn_Submit.TabIndex = 17;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_AccntNmbr
            // 
            this.lbl_AccntNmbr.AutoSize = true;
            this.lbl_AccntNmbr.Font = new System.Drawing.Font("Verdana", 14F);
            this.lbl_AccntNmbr.ForeColor = System.Drawing.Color.White;
            this.lbl_AccntNmbr.Location = new System.Drawing.Point(247, 141);
            this.lbl_AccntNmbr.Name = "lbl_AccntNmbr";
            this.lbl_AccntNmbr.Size = new System.Drawing.Size(257, 23);
            this.lbl_AccntNmbr.TabIndex = 19;
            this.lbl_AccntNmbr.Text = "Choose Security Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Choose Account Type";
            // 
            // tb_SecurityQAnswer
            // 
            this.tb_SecurityQAnswer.Font = new System.Drawing.Font("Verdana", 14F);
            this.tb_SecurityQAnswer.Location = new System.Drawing.Point(531, 182);
            this.tb_SecurityQAnswer.Name = "tb_SecurityQAnswer";
            this.tb_SecurityQAnswer.Size = new System.Drawing.Size(230, 30);
            this.tb_SecurityQAnswer.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(167, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Enter Answer to security Question";
            // 
            // CreateNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_SecurityQAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_AccntNmbr);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cb_SecurityQuestion);
            this.Controls.Add(this.cb_AccountType);
            this.Controls.Add(this.tb_welcomeBanner);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Name = "CreateNewAccount";
            this.Text = "CreateNewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label tb_welcomeBanner;
        private System.Windows.Forms.ComboBox cb_AccountType;
        private System.Windows.Forms.ComboBox cb_SecurityQuestion;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_AccntNmbr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SecurityQAnswer;
        private System.Windows.Forms.Label label2;
    }
}