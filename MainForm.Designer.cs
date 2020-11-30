namespace WindowsFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ArticlesPanel = new System.Windows.Forms.Panel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.AuthorFilterBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TopicFilterBox = new System.Windows.Forms.ComboBox();
            this.TagFilterBox = new System.Windows.Forms.ComboBox();
            this.AdvertistingPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SignInLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.UserInfoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ArticlesPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.AdvertistingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AuthPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArticlesPanel
            // 
            this.ArticlesPanel.Controls.Add(this.panel1);
            this.ArticlesPanel.Controls.Add(this.filterPanel);
            this.ArticlesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArticlesPanel.Location = new System.Drawing.Point(180, 40);
            this.ArticlesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArticlesPanel.Name = "ArticlesPanel";
            this.ArticlesPanel.Size = new System.Drawing.Size(662, 347);
            this.ArticlesPanel.TabIndex = 1;
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.AuthorFilterBox);
            this.filterPanel.Controls.Add(this.label5);
            this.filterPanel.Controls.Add(this.TopicFilterBox);
            this.filterPanel.Controls.Add(this.label4);
            this.filterPanel.Controls.Add(this.label3);
            this.filterPanel.Controls.Add(this.label1);
            this.filterPanel.Controls.Add(this.TagFilterBox);
            this.filterPanel.Controls.Add(this.findButton);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(662, 60);
            this.filterPanel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Темы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Теги";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(593, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Все статьи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // findButton
            // 
            this.findButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.findButton.Location = new System.Drawing.Point(593, 0);
            this.findButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(69, 60);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Поиск";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // AuthorFilterBox
            // 
            this.AuthorFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorFilterBox.FormattingEnabled = true;
            this.AuthorFilterBox.Location = new System.Drawing.Point(457, 30);
            this.AuthorFilterBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuthorFilterBox.Name = "AuthorFilterBox";
            this.AuthorFilterBox.Size = new System.Drawing.Size(132, 28);
            this.AuthorFilterBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Автор";
            // 
            // TopicFilterBox
            // 
            this.TopicFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TopicFilterBox.FormattingEnabled = true;
            this.TopicFilterBox.Location = new System.Drawing.Point(261, 30);
            this.TopicFilterBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopicFilterBox.Name = "TopicFilterBox";
            this.TopicFilterBox.Size = new System.Drawing.Size(132, 28);
            this.TopicFilterBox.TabIndex = 5;
            // 
            // TagFilterBox
            // 
            this.TagFilterBox.Location = new System.Drawing.Point(51, 30);
            this.TagFilterBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TagFilterBox.Name = "TagFilterBox";
            this.TagFilterBox.Size = new System.Drawing.Size(153, 28);
            this.TagFilterBox.TabIndex = 2;
            // 
            // AdvertistingPanel
            // 
            this.AdvertistingPanel.Controls.Add(this.label2);
            this.AdvertistingPanel.Controls.Add(this.pictureBox1);
            this.AdvertistingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdvertistingPanel.Location = new System.Drawing.Point(0, 40);
            this.AdvertistingPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdvertistingPanel.Name = "AdvertistingPanel";
            this.AdvertistingPanel.Size = new System.Drawing.Size(180, 347);
            this.AdvertistingPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Реклама";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.renderforest_300x600;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SignInLabel
            // 
            this.SignInLabel.Location = new System.Drawing.Point(11, 9);
            this.SignInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(219, 23);
            this.SignInLabel.TabIndex = 2;
            this.SignInLabel.Text = "Вы ещё не вошли в аккаунт";
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(232, 4);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(79, 31);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.Text = "Войти";
            this.SignInButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AuthPanel
            // 
            this.AuthPanel.Controls.Add(this.button2);
            this.AuthPanel.Controls.Add(this.AdminButton);
            this.AuthPanel.Controls.Add(this.UserInfoButton);
            this.AuthPanel.Controls.Add(this.SignInButton);
            this.AuthPanel.Controls.Add(this.SignInLabel);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(842, 40);
            this.AuthPanel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(773, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Обновить данные";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AdminButton
            // 
            this.AdminButton.Location = new System.Drawing.Point(408, 4);
            this.AdminButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(179, 30);
            this.AdminButton.TabIndex = 5;
            this.AdminButton.Text = "Администрирование";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Visible = false;
            this.AdminButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // UserInfoButton
            // 
            this.UserInfoButton.Location = new System.Drawing.Point(232, 4);
            this.UserInfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserInfoButton.Name = "UserInfoButton";
            this.UserInfoButton.Size = new System.Drawing.Size(172, 30);
            this.UserInfoButton.TabIndex = 4;
            this.UserInfoButton.Text = "Личный кабинет";
            this.UserInfoButton.UseVisualStyleBackColor = true;
            this.UserInfoButton.Visible = false;
            this.UserInfoButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 287);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 387);
            this.Controls.Add(this.ArticlesPanel);
            this.Controls.Add(this.AdvertistingPanel);
            this.Controls.Add(this.AuthPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Кликни, чтобы открыть статью";
            this.ArticlesPanel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.AdvertistingPanel.ResumeLayout(false);
            this.AdvertistingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AuthPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ArticlesPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel AdvertistingPanel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Button UserInfoButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ComboBox TagFilterBox;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TopicFilterBox;
        private System.Windows.Forms.ComboBox AuthorFilterBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}