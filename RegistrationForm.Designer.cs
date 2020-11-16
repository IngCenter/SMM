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
            this.RegistrationButton.Location = new System.Drawing.Point(0, 103);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(297, 26);
            this.RegistrationButton.TabIndex = 14;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordRLabel
            // 
            this.PasswordRLabel.AutoSize = true;
            this.PasswordRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordRLabel.Location = new System.Drawing.Point(11, 79);
            this.PasswordRLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordRLabel.Name = "PasswordRLabel";
            this.PasswordRLabel.Size = new System.Drawing.Size(51, 13);
            this.PasswordRLabel.TabIndex = 13;
            this.PasswordRLabel.Text = "Пароль";
            // 
            // UserNameRLabel
            // 
            this.UserNameRLabel.AutoSize = true;
            this.UserNameRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameRLabel.Location = new System.Drawing.Point(11, 31);
            this.UserNameRLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameRLabel.Name = "UserNameRLabel";
            this.UserNameRLabel.Size = new System.Drawing.Size(119, 13);
            this.UserNameRLabel.TabIndex = 12;
            this.UserNameRLabel.Text = "Имя пользователя";
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.Location = new System.Drawing.Point(11, 9);
            this.RegistrationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(178, 13);
            this.RegistrationLabel.TabIndex = 8;
            this.RegistrationLabel.Text = "Введите данные для регистрации";
            // 
            // LoginRLabel
            // 
            this.LoginRLabel.AutoSize = true;
            this.LoginRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginRLabel.Location = new System.Drawing.Point(11, 55);
            this.LoginRLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginRLabel.Name = "LoginRLabel";
            this.LoginRLabel.Size = new System.Drawing.Size(43, 13);
            this.LoginRLabel.TabIndex = 16;
            this.LoginRLabel.Text = "Логин";
            // 
            // UserNameRTB
            // 
            this.UserNameRTB.Location = new System.Drawing.Point(134, 28);
            this.UserNameRTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserNameRTB.Name = "UserNameRTB";
            this.UserNameRTB.Size = new System.Drawing.Size(143, 20);
            this.UserNameRTB.TabIndex = 17;
            this.UserNameRTB.TextChanged += new System.EventHandler(this.UserNameRTB_TextChanged);
            // 
            // LoginRTB
            // 
            this.LoginRTB.Location = new System.Drawing.Point(134, 52);
            this.LoginRTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginRTB.Name = "LoginRTB";
            this.LoginRTB.Size = new System.Drawing.Size(143, 20);
            this.LoginRTB.TabIndex = 18;
            // 
            // PasswordRTB
            // 
            this.PasswordRTB.Location = new System.Drawing.Point(134, 76);
            this.PasswordRTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordRTB.Name = "PasswordRTB";
            this.PasswordRTB.Size = new System.Drawing.Size(143, 20);
            this.PasswordRTB.TabIndex = 19;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 129);
            this.Controls.Add(this.PasswordRTB);
            this.Controls.Add(this.LoginRTB);
            this.Controls.Add(this.UserNameRTB);
            this.Controls.Add(this.LoginRLabel);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.PasswordRLabel);
            this.Controls.Add(this.UserNameRLabel);
            this.Controls.Add(this.RegistrationLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
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