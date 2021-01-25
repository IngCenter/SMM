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
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TopicFilterBox = new System.Windows.Forms.ComboBox();
            this.FilterTB = new System.Windows.Forms.TextBox();
            this.AuthorFilterBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TagFilterBox = new System.Windows.Forms.ComboBox();
            this.findButton = new System.Windows.Forms.Button();
            this.AdvertistingPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SignInLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.UserInfoButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ArticlesPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.AdvertistingPanel.SuspendLayout();
            this.AuthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticlesPanel
            // 
            this.ArticlesPanel.Controls.Add(this.panel1);
            this.ArticlesPanel.Controls.Add(this.filterPanel);
            this.ArticlesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArticlesPanel.Location = new System.Drawing.Point(220, 44);
            this.ArticlesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ArticlesPanel.Name = "ArticlesPanel";
            this.ArticlesPanel.Size = new System.Drawing.Size(855, 440);
            this.ArticlesPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 367);
            this.panel1.TabIndex = 4;
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.comboBox1);
            this.filterPanel.Controls.Add(this.TopicFilterBox);
            this.filterPanel.Controls.Add(this.FilterTB);
            this.filterPanel.Controls.Add(this.AuthorFilterBox);
            this.filterPanel.Controls.Add(this.label5);
            this.filterPanel.Controls.Add(this.label4);
            this.filterPanel.Controls.Add(this.label3);
            this.filterPanel.Controls.Add(this.label1);
            this.filterPanel.Controls.Add(this.TagFilterBox);
            this.filterPanel.Controls.Add(this.findButton);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(855, 73);
            this.filterPanel.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.comboBox1.Items.AddRange(new object[] {
            "Кухня"});
            this.comboBox1.Location = new System.Drawing.Point(462, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 33);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TopicFilterBox
            // 
            this.TopicFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TopicFilterBox.FormattingEnabled = true;
            this.TopicFilterBox.Location = new System.Drawing.Point(326, 38);
            this.TopicFilterBox.Name = "TopicFilterBox";
            this.TopicFilterBox.Size = new System.Drawing.Size(186, 33);
            this.TopicFilterBox.TabIndex = 5;
            this.TopicFilterBox.SelectedIndexChanged += new System.EventHandler(this.TopicFilterBox_SelectedIndexChanged);
            // 
            // FilterTB
            // 
            this.FilterTB.Location = new System.Drawing.Point(6, 3);
            this.FilterTB.Name = "FilterTB";
            this.FilterTB.Size = new System.Drawing.Size(316, 30);
            this.FilterTB.TabIndex = 2;
            // 
            // AuthorFilterBox
            // 
            this.AuthorFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorFilterBox.FormattingEnabled = true;
            this.AuthorFilterBox.Location = new System.Drawing.Point(609, 37);
            this.AuthorFilterBox.Name = "AuthorFilterBox";
            this.AuthorFilterBox.Size = new System.Drawing.Size(162, 33);
            this.AuthorFilterBox.TabIndex = 7;
            this.AuthorFilterBox.SelectedIndexChanged += new System.EventHandler(this.AuthorFilterBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Автор";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Темы";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(774, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Все статьи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Теги";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TagFilterBox
            // 
            this.TagFilterBox.Location = new System.Drawing.Point(66, 38);
            this.TagFilterBox.Name = "TagFilterBox";
            this.TagFilterBox.Size = new System.Drawing.Size(189, 33);
            this.TagFilterBox.TabIndex = 2;
            this.TagFilterBox.SelectedIndexChanged += new System.EventHandler(this.TagFilterBox_SelectedIndexChanged);
            // 
            // findButton
            // 
            this.findButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.findButton.Location = new System.Drawing.Point(774, 0);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(81, 73);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Поиск";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // AdvertistingPanel
            // 
            this.AdvertistingPanel.Controls.Add(this.label2);
            this.AdvertistingPanel.Controls.Add(this.pictureBox1);
            this.AdvertistingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdvertistingPanel.Location = new System.Drawing.Point(0, 44);
            this.AdvertistingPanel.Name = "AdvertistingPanel";
            this.AdvertistingPanel.Size = new System.Drawing.Size(220, 440);
            this.AdvertistingPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Реклама";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SignInLabel
            // 
            this.SignInLabel.Location = new System.Drawing.Point(12, 12);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(292, 29);
            this.SignInLabel.TabIndex = 2;
            this.SignInLabel.Text = "Вы ещё не вошли в аккаунт";
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(298, 5);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(92, 35);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.Text = "Войти";
            this.SignInButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AuthPanel
            // 
            this.AuthPanel.Controls.Add(this.button2);
            this.AuthPanel.Controls.Add(this.UserInfoButton);
            this.AuthPanel.Controls.Add(this.AdminButton);
            this.AuthPanel.Controls.Add(this.SignInButton);
            this.AuthPanel.Controls.Add(this.SignInLabel);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1075, 44);
            this.AuthPanel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(848, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Обновить данные";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UserInfoButton
            // 
            this.UserInfoButton.Location = new System.Drawing.Point(298, 3);
            this.UserInfoButton.Name = "UserInfoButton";
            this.UserInfoButton.Size = new System.Drawing.Size(186, 38);
            this.UserInfoButton.TabIndex = 4;
            this.UserInfoButton.Text = "Личный кабинет";
            this.UserInfoButton.UseVisualStyleBackColor = true;
            this.UserInfoButton.Visible = false;
            this.UserInfoButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminButton
            // 
            this.AdminButton.Location = new System.Drawing.Point(490, 3);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(352, 38);
            this.AdminButton.TabIndex = 5;
            this.AdminButton.Text = "Администрирование";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Visible = false;
            this.AdminButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.renderforest_300x600;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 484);
            this.Controls.Add(this.ArticlesPanel);
            this.Controls.Add(this.AdvertistingPanel);
            this.Controls.Add(this.AuthPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Кликни, чтобы открыть статью";
            this.ArticlesPanel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.AdvertistingPanel.ResumeLayout(false);
            this.AdvertistingPanel.PerformLayout();
            this.AuthPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox FilterTB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox TopicFilterBox;
        private System.Windows.Forms.ComboBox AuthorFilterBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}