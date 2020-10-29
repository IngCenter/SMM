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
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPB)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(31, 25);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(194, 25);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "Имя Пользователя";
            // 
            // UserArticleLabel
            // 
            this.UserArticleLabel.AutoSize = true;
            this.UserArticleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserArticleLabel.Location = new System.Drawing.Point(32, 120);
            this.UserArticleLabel.Name = "UserArticleLabel";
            this.UserArticleLabel.Size = new System.Drawing.Size(195, 20);
            this.UserArticleLabel.TabIndex = 1;
            this.UserArticleLabel.Text = "Статьи пользователя";
            this.UserArticleLabel.Click += new System.EventHandler(this.UserArticleLabel_Click);
            // 
            // UserFeedBackLabel
            // 
            this.UserFeedBackLabel.AutoSize = true;
            this.UserFeedBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserFeedBackLabel.Location = new System.Drawing.Point(31, 154);
            this.UserFeedBackLabel.Name = "UserFeedBackLabel";
            this.UserFeedBackLabel.Size = new System.Drawing.Size(165, 20);
            this.UserFeedBackLabel.TabIndex = 2;
            this.UserFeedBackLabel.Text = "Отзывы к статьям";
            this.UserFeedBackLabel.Click += new System.EventHandler(this.UserFeedBackLabel_Click);
            // 
            // MonetizationLabel
            // 
            this.MonetizationLabel.AutoSize = true;
            this.MonetizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonetizationLabel.Location = new System.Drawing.Point(31, 190);
            this.MonetizationLabel.Name = "MonetizationLabel";
            this.MonetizationLabel.Size = new System.Drawing.Size(212, 20);
            this.MonetizationLabel.TabIndex = 3;
            this.MonetizationLabel.Text = "Монетизация к статьям";
            this.MonetizationLabel.Click += new System.EventHandler(this.MonetizationLabel_Click);
            // 
            // SubscribersLabel
            // 
            this.SubscribersLabel.AutoSize = true;
            this.SubscribersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubscribersLabel.Location = new System.Drawing.Point(32, 85);
            this.SubscribersLabel.Name = "SubscribersLabel";
            this.SubscribersLabel.Size = new System.Drawing.Size(224, 20);
            this.SubscribersLabel.TabIndex = 4;
            this.SubscribersLabel.Text = "Количество подписчиков";
            this.SubscribersLabel.Click += new System.EventHandler(this.SubscribersLabel_Click);
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Location = new System.Drawing.Point(33, 50);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(21, 17);
            this.UserIDLabel.TabIndex = 5;
            this.UserIDLabel.Text = "ID";
            // 
            // AvatarPB
            // 
            this.AvatarPB.Location = new System.Drawing.Point(369, 25);
            this.AvatarPB.Name = "AvatarPB";
            this.AvatarPB.Size = new System.Drawing.Size(189, 185);
            this.AvatarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarPB.TabIndex = 6;
            this.AvatarPB.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 244);
            this.Controls.Add(this.AvatarPB);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.SubscribersLabel);
            this.Controls.Add(this.MonetizationLabel);
            this.Controls.Add(this.UserFeedBackLabel);
            this.Controls.Add(this.UserArticleLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Name = "UserForm";
            this.Text = "UserFormcs";
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
    }
}