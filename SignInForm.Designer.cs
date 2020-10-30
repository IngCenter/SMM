namespace WindowsFormsApp2
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
            this.SignInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInLabel.Location = new System.Drawing.Point(50, 39);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(156, 18);
            this.SignInLabel.TabIndex = 0;
            this.SignInLabel.Text = "Выполните вход или ";
            // 
            // SignInLLabel
            // 
            this.SignInLLabel.AutoSize = true;
            this.SignInLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInLLabel.Location = new System.Drawing.Point(201, 39);
            this.SignInLLabel.Name = "SignInLLabel";
            this.SignInLLabel.Size = new System.Drawing.Size(143, 18);
            this.SignInLLabel.TabIndex = 1;
            this.SignInLLabel.TabStop = true;
            this.SignInLLabel.Text = "зарегистрируйтесь:";
            this.SignInLLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignInLLabel_LinkClicked);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(50, 82);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(50, 18);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(50, 130);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 17);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Пароль";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(154, 82);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(178, 22);
            this.LoginTB.TabIndex = 8;
            // 
            // PasswordMTB
            // 
            this.PasswordMTB.Location = new System.Drawing.Point(154, 130);
            this.PasswordMTB.Name = "PasswordMTB";
            this.PasswordMTB.Size = new System.Drawing.Size(178, 22);
            this.PasswordMTB.TabIndex = 9;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 234);
            this.Controls.Add(this.PasswordMTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.SignInLLabel);
            this.Controls.Add(this.SignInLabel);
            this.Name = "SignInForm";
            this.Text = "SignIn";
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