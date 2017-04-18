namespace BankingApplicationProgram
{
    partial class AddExistingAccount
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_AccountNumber = new System.Windows.Forms.TextBox();
            this.lbl_AccntNmbr = new System.Windows.Forms.Label();
            this.lb_SecurityQuestion = new System.Windows.Forms.Label();
            this.tb_AnswerBox = new System.Windows.Forms.TextBox();
            this.btn_SubmitSQAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(12, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(872, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(25)))));
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(685, 146);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(100, 30);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Existing Account";
            // 
            // tb_AccountNumber
            // 
            this.tb_AccountNumber.Font = new System.Drawing.Font("Verdana", 14F);
            this.tb_AccountNumber.Location = new System.Drawing.Point(429, 146);
            this.tb_AccountNumber.Name = "tb_AccountNumber";
            this.tb_AccountNumber.Size = new System.Drawing.Size(240, 30);
            this.tb_AccountNumber.TabIndex = 15;
            // 
            // lbl_AccntNmbr
            // 
            this.lbl_AccntNmbr.AutoSize = true;
            this.lbl_AccntNmbr.Font = new System.Drawing.Font("Verdana", 14F);
            this.lbl_AccntNmbr.ForeColor = System.Drawing.Color.White;
            this.lbl_AccntNmbr.Location = new System.Drawing.Point(239, 149);
            this.lbl_AccntNmbr.Name = "lbl_AccntNmbr";
            this.lbl_AccntNmbr.Size = new System.Drawing.Size(168, 23);
            this.lbl_AccntNmbr.TabIndex = 18;
            this.lbl_AccntNmbr.Text = "Account Number";
            // 
            // lb_SecurityQuestion
            // 
            this.lb_SecurityQuestion.AutoSize = true;
            this.lb_SecurityQuestion.Font = new System.Drawing.Font("Verdana", 14F);
            this.lb_SecurityQuestion.ForeColor = System.Drawing.Color.White;
            this.lb_SecurityQuestion.Location = new System.Drawing.Point(239, 197);
            this.lb_SecurityQuestion.Name = "lb_SecurityQuestion";
            this.lb_SecurityQuestion.Size = new System.Drawing.Size(0, 23);
            this.lb_SecurityQuestion.TabIndex = 20;
            // 
            // tb_AnswerBox
            // 
            this.tb_AnswerBox.Font = new System.Drawing.Font("Verdana", 14F);
            this.tb_AnswerBox.Location = new System.Drawing.Point(429, 246);
            this.tb_AnswerBox.Name = "tb_AnswerBox";
            this.tb_AnswerBox.Size = new System.Drawing.Size(240, 30);
            this.tb_AnswerBox.TabIndex = 21;
            this.tb_AnswerBox.Visible = false;
            // 
            // btn_SubmitSQAnswer
            // 
            this.btn_SubmitSQAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(25)))));
            this.btn_SubmitSQAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SubmitSQAnswer.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_SubmitSQAnswer.ForeColor = System.Drawing.Color.Black;
            this.btn_SubmitSQAnswer.Location = new System.Drawing.Point(685, 246);
            this.btn_SubmitSQAnswer.Name = "btn_SubmitSQAnswer";
            this.btn_SubmitSQAnswer.Size = new System.Drawing.Size(108, 54);
            this.btn_SubmitSQAnswer.TabIndex = 22;
            this.btn_SubmitSQAnswer.Text = "Submit Answer";
            this.btn_SubmitSQAnswer.UseVisualStyleBackColor = false;
            this.btn_SubmitSQAnswer.Visible = false;
            this.btn_SubmitSQAnswer.Click += new System.EventHandler(this.btn_SubmitSQAnswer_Click);
            // 
            // AddExistingAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btn_SubmitSQAnswer);
            this.Controls.Add(this.tb_AnswerBox);
            this.Controls.Add(this.lb_SecurityQuestion);
            this.Controls.Add(this.lbl_AccntNmbr);
            this.Controls.Add(this.tb_AccountNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label1);
            this.Name = "AddExistingAccount";
            this.Text = "AddExistingAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_AccountNumber;
        private System.Windows.Forms.Label lbl_AccntNmbr;
        private System.Windows.Forms.Label lb_SecurityQuestion;
        private System.Windows.Forms.TextBox tb_AnswerBox;
        private System.Windows.Forms.Button btn_SubmitSQAnswer;
    }
}