﻿namespace WindowsFormsApp2
{
    partial class SignInForm
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
            this.SignInLabel = new System.Windows.Forms.Label();
            this.SignInLLabel = new System.Windows.Forms.LinkLabel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordMTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SignInLabel.Location = new System.Drawing.Point(28, 20);
            this.SignInLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(260, 29);
            this.SignInLabel.TabIndex = 0;
            this.SignInLabel.Text = "Выполните вход или ";
            // 
            // SignInLLabel
            // 
            this.SignInLLabel.AutoSize = true;
            this.SignInLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SignInLLabel.Location = new System.Drawing.Point(286, 20);
            this.SignInLLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SignInLLabel.Name = "SignInLLabel";
            this.SignInLLabel.Size = new System.Drawing.Size(236, 29);
            this.SignInLLabel.TabIndex = 1;
            this.SignInLLabel.TabStop = true;
            this.SignInLLabel.Text = "зарегистрируйтесь";
            this.SignInLLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignInLLabel_LinkClicked);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LoginLabel.Location = new System.Drawing.Point(36, 76);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(88, 29);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.Location = new System.Drawing.Point(34, 145);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 29);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Пароль";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(587, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(180, 76);
            this.LoginTB.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(368, 36);
            this.LoginTB.TabIndex = 8;
            // 
            // PasswordMTB
            // 
            this.PasswordMTB.Location = new System.Drawing.Point(180, 143);
            this.PasswordMTB.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.PasswordMTB.Name = "PasswordMTB";
            this.PasswordMTB.Size = new System.Drawing.Size(370, 36);
            this.PasswordMTB.TabIndex = 9;
            this.PasswordMTB.UseSystemPasswordChar = true;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PasswordMTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.SignInLLabel);
            this.Controls.Add(this.SignInLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "SignInForm";
            this.Size = new System.Drawing.Size(587, 257);
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.LinkLabel SignInLLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasswordMTB;
    }
}