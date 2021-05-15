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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserArticleLabel = new System.Windows.Forms.Label();
            this.UserFeedBackLabel = new System.Windows.Forms.Label();
            this.MonetizationLabel = new System.Windows.Forms.Label();
            this.UserSubsLabel = new System.Windows.Forms.Label();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.AvatarPB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPB)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(28, 20);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(194, 25);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "Имя Пользователя";
            // 
            // UserArticleLabel
            // 
            this.UserArticleLabel.AutoSize = true;
            this.UserArticleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserArticleLabel.Location = new System.Drawing.Point(30, 143);
            this.UserArticleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
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
            this.UserFeedBackLabel.Location = new System.Drawing.Point(30, 181);
            this.UserFeedBackLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
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
            this.MonetizationLabel.Location = new System.Drawing.Point(30, 219);
            this.MonetizationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MonetizationLabel.Name = "MonetizationLabel";
            this.MonetizationLabel.Size = new System.Drawing.Size(212, 20);
            this.MonetizationLabel.TabIndex = 3;
            this.MonetizationLabel.Text = "Монетизация к статьям";
            // 
            // UserSubsLabel
            // 
            this.UserSubsLabel.AutoSize = true;
            this.UserSubsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserSubsLabel.Location = new System.Drawing.Point(30, 105);
            this.UserSubsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserSubsLabel.Name = "UserSubsLabel";
            this.UserSubsLabel.Size = new System.Drawing.Size(224, 20);
            this.UserSubsLabel.TabIndex = 4;
            this.UserSubsLabel.Text = "Количество подписчиков";
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserIDLabel.Location = new System.Drawing.Point(30, 65);
            this.UserIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(27, 24);
            this.UserIDLabel.TabIndex = 5;
            this.UserIDLabel.Text = "ID";
            // 
            // AvatarPB
            // 
            this.AvatarPB.Image = ((System.Drawing.Image)(resources.GetObject("AvatarPB.Image")));
            this.AvatarPB.Location = new System.Drawing.Point(581, 40);
            this.AvatarPB.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.AvatarPB.Name = "AvatarPB";
            this.AvatarPB.Size = new System.Drawing.Size(332, 297);
            this.AvatarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarPB.TabIndex = 6;
            this.AvatarPB.TabStop = false;
            this.AvatarPB.Click += new System.EventHandler(this.AvatarPB_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(39, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выйти из аккаунта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(377, 315);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 33);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Disable Ad";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "avatarka.png";
            this.openFileDialog1.Filter = "Изображения (*.jpg;*.jpeg;*.png;*.bmp;*.webp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.we" +
    "bp;*.gif|Все файлы (*.*)|*.*";
            this.openFileDialog1.Title = "Выберите иображение для аватарки своего профиля";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Подписки";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AvatarPB);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.UserSubsLabel);
            this.Controls.Add(this.MonetizationLabel);
            this.Controls.Add(this.UserFeedBackLabel);
            this.Controls.Add(this.UserArticleLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "UserForm";
            this.Size = new System.Drawing.Size(936, 392);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserArticleLabel;
        private System.Windows.Forms.Label UserFeedBackLabel;
        private System.Windows.Forms.Label MonetizationLabel;
        private System.Windows.Forms.Label UserSubsLabel;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.PictureBox AvatarPB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}