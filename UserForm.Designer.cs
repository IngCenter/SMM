namespace WindowsFormsApp2
{
    partial class UserForm
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserArticleLabel = new System.Windows.Forms.Label();
            this.UserFeedBackLabel = new System.Windows.Forms.Label();
            this.MonetizationLabel = new System.Windows.Forms.Label();
            this.SubscribersLabel = new System.Windows.Forms.Label();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.AvatarPB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPB)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(11, 9);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(156, 20);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "Имя Пользователя";
            // 
            // UserArticleLabel
            // 
            this.UserArticleLabel.AutoSize = true;
            this.UserArticleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserArticleLabel.Location = new System.Drawing.Point(12, 64);
            this.UserArticleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserArticleLabel.Name = "UserArticleLabel";
            this.UserArticleLabel.Size = new System.Drawing.Size(150, 17);
            this.UserArticleLabel.TabIndex = 1;
            this.UserArticleLabel.Text = "Статьи пользователя";
            this.UserArticleLabel.Click += new System.EventHandler(this.UserArticleLabel_Click);
            // 
            // UserFeedBackLabel
            // 
            this.UserFeedBackLabel.AutoSize = true;
            this.UserFeedBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserFeedBackLabel.Location = new System.Drawing.Point(12, 81);
            this.UserFeedBackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserFeedBackLabel.Name = "UserFeedBackLabel";
            this.UserFeedBackLabel.Size = new System.Drawing.Size(128, 17);
            this.UserFeedBackLabel.TabIndex = 2;
            this.UserFeedBackLabel.Text = "Отзывы к статьям";
            // 
            // MonetizationLabel
            // 
            this.MonetizationLabel.AutoSize = true;
            this.MonetizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonetizationLabel.Location = new System.Drawing.Point(12, 98);
            this.MonetizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MonetizationLabel.Name = "MonetizationLabel";
            this.MonetizationLabel.Size = new System.Drawing.Size(165, 17);
            this.MonetizationLabel.TabIndex = 3;
            this.MonetizationLabel.Text = "Монетизация к статьям";
            // 
            // SubscribersLabel
            // 
            this.SubscribersLabel.AutoSize = true;
            this.SubscribersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubscribersLabel.Location = new System.Drawing.Point(12, 47);
            this.SubscribersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubscribersLabel.Name = "SubscribersLabel";
            this.SubscribersLabel.Size = new System.Drawing.Size(175, 17);
            this.SubscribersLabel.TabIndex = 4;
            this.SubscribersLabel.Text = "Количество подписчиков";
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserIDLabel.Location = new System.Drawing.Point(12, 29);
            this.UserIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(22, 18);
            this.UserIDLabel.TabIndex = 5;
            this.UserIDLabel.Text = "ID";
            // 
            // AvatarPB
            // 
            this.AvatarPB.Location = new System.Drawing.Point(232, 9);
            this.AvatarPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AvatarPB.Name = "AvatarPB";
            this.AvatarPB.Size = new System.Drawing.Size(133, 133);
            this.AvatarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarPB.TabIndex = 6;
            this.AvatarPB.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 117);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выйти из аккаунта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 150);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AvatarPB);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.SubscribersLabel);
            this.Controls.Add(this.MonetizationLabel);
            this.Controls.Add(this.UserFeedBackLabel);
            this.Controls.Add(this.UserArticleLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "Личный кабинет";
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserArticleLabel;
        private System.Windows.Forms.Label UserFeedBackLabel;
        private System.Windows.Forms.Label MonetizationLabel;
        private System.Windows.Forms.Label SubscribersLabel;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.PictureBox AvatarPB;
        private System.Windows.Forms.Button button1;
    }
}