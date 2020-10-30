namespace WindowsFormsApp2
{
    partial class RegistrationForm
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
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.PasswordRLabel = new System.Windows.Forms.Label();
            this.UserNameRLabel = new System.Windows.Forms.Label();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.LoginRLabel = new System.Windows.Forms.Label();
            this.UserNameRTB = new System.Windows.Forms.TextBox();
            this.LoginRTB = new System.Windows.Forms.TextBox();
            this.PasswordRTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(133, 171);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(163, 36);
            this.RegistrationButton.TabIndex = 14;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordRLabel
            // 
            this.PasswordRLabel.AutoSize = true;
            this.PasswordRLabel.Location = new System.Drawing.Point(29, 133);
            this.PasswordRLabel.Name = "PasswordRLabel";
            this.PasswordRLabel.Size = new System.Drawing.Size(57, 17);
            this.PasswordRLabel.TabIndex = 13;
            this.PasswordRLabel.Text = "Пароль";
            // 
            // UserNameRLabel
            // 
            this.UserNameRLabel.AutoSize = true;
            this.UserNameRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameRLabel.Location = new System.Drawing.Point(29, 64);
            this.UserNameRLabel.Name = "UserNameRLabel";
            this.UserNameRLabel.Size = new System.Drawing.Size(141, 18);
            this.UserNameRLabel.TabIndex = 12;
            this.UserNameRLabel.Text = "Имя пользователя";
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.Location = new System.Drawing.Point(29, 24);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(211, 18);
            this.RegistrationLabel.TabIndex = 8;
            this.RegistrationLabel.Text = "Введите имя, логин и пароль";
            // 
            // LoginRLabel
            // 
            this.LoginRLabel.AutoSize = true;
            this.LoginRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginRLabel.Location = new System.Drawing.Point(29, 97);
            this.LoginRLabel.Name = "LoginRLabel";
            this.LoginRLabel.Size = new System.Drawing.Size(50, 18);
            this.LoginRLabel.TabIndex = 16;
            this.LoginRLabel.Text = "Логин";
            // 
            // UserNameRTB
            // 
            this.UserNameRTB.Location = new System.Drawing.Point(191, 64);
            this.UserNameRTB.Name = "UserNameRTB";
            this.UserNameRTB.Size = new System.Drawing.Size(178, 22);
            this.UserNameRTB.TabIndex = 17;
            // 
            // LoginRTB
            // 
            this.LoginRTB.Location = new System.Drawing.Point(191, 96);
            this.LoginRTB.Name = "LoginRTB";
            this.LoginRTB.Size = new System.Drawing.Size(178, 22);
            this.LoginRTB.TabIndex = 18;
            // 
            // PasswordRTB
            // 
            this.PasswordRTB.Location = new System.Drawing.Point(191, 130);
            this.PasswordRTB.Name = "PasswordRTB";
            this.PasswordRTB.Size = new System.Drawing.Size(178, 22);
            this.PasswordRTB.TabIndex = 19;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 234);
            this.Controls.Add(this.PasswordRTB);
            this.Controls.Add(this.LoginRTB);
            this.Controls.Add(this.UserNameRTB);
            this.Controls.Add(this.LoginRLabel);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.PasswordRLabel);
            this.Controls.Add(this.UserNameRLabel);
            this.Controls.Add(this.RegistrationLabel);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label PasswordRLabel;
        private System.Windows.Forms.Label UserNameRLabel;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Label LoginRLabel;
        private System.Windows.Forms.TextBox UserNameRTB;
        private System.Windows.Forms.TextBox LoginRTB;
        private System.Windows.Forms.TextBox PasswordRTB;
    }
}