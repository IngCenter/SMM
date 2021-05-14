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
            this.RegistrationButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.RegistrationButton.Location = new System.Drawing.Point(0, 230);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(742, 58);
            this.RegistrationButton.TabIndex = 14;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordRLabel
            // 
            this.PasswordRLabel.AutoSize = true;
            this.PasswordRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.PasswordRLabel.Location = new System.Drawing.Point(32, 176);
            this.PasswordRLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PasswordRLabel.Name = "PasswordRLabel";
            this.PasswordRLabel.Size = new System.Drawing.Size(106, 29);
            this.PasswordRLabel.TabIndex = 13;
            this.PasswordRLabel.Text = "Пароль";
            // 
            // UserNameRLabel
            // 
            this.UserNameRLabel.AutoSize = true;
            this.UserNameRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.UserNameRLabel.Location = new System.Drawing.Point(28, 69);
            this.UserNameRLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserNameRLabel.Name = "UserNameRLabel";
            this.UserNameRLabel.Size = new System.Drawing.Size(248, 29);
            this.UserNameRLabel.TabIndex = 12;
            this.UserNameRLabel.Text = "Имя пользователя";
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.RegistrationLabel.Location = new System.Drawing.Point(25, 16);
            this.RegistrationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(471, 33);
            this.RegistrationLabel.TabIndex = 8;
            this.RegistrationLabel.Text = "Введите данные для регистрации";
            // 
            // LoginRLabel
            // 
            this.LoginRLabel.AutoSize = true;
            this.LoginRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LoginRLabel.Location = new System.Drawing.Point(34, 123);
            this.LoginRLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LoginRLabel.Name = "LoginRLabel";
            this.LoginRLabel.Size = new System.Drawing.Size(88, 29);
            this.LoginRLabel.TabIndex = 16;
            this.LoginRLabel.Text = "Логин";
            // 
            // UserNameRTB
            // 
            this.UserNameRTB.Location = new System.Drawing.Point(336, 62);
            this.UserNameRTB.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.UserNameRTB.Name = "UserNameRTB";
            this.UserNameRTB.Size = new System.Drawing.Size(351, 36);
            this.UserNameRTB.TabIndex = 17;
            this.UserNameRTB.TextChanged += new System.EventHandler(this.UserNameRTB_TextChanged);
            // 
            // LoginRTB
            // 
            this.LoginRTB.Location = new System.Drawing.Point(336, 116);
            this.LoginRTB.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.LoginRTB.Name = "LoginRTB";
            this.LoginRTB.Size = new System.Drawing.Size(351, 36);
            this.LoginRTB.TabIndex = 18;
            // 
            // PasswordRTB
            // 
            this.PasswordRTB.Location = new System.Drawing.Point(336, 170);
            this.PasswordRTB.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.PasswordRTB.Name = "PasswordRTB";
            this.PasswordRTB.Size = new System.Drawing.Size(351, 36);
            this.PasswordRTB.TabIndex = 19;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PasswordRTB);
            this.Controls.Add(this.LoginRTB);
            this.Controls.Add(this.UserNameRTB);
            this.Controls.Add(this.LoginRLabel);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.PasswordRLabel);
            this.Controls.Add(this.UserNameRLabel);
            this.Controls.Add(this.RegistrationLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "RegistrationForm";
            this.Size = new System.Drawing.Size(742, 288);
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