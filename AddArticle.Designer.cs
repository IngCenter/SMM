namespace WindowsFormsApp2
{
    partial class AddArticle
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
            this.components = new System.ComponentModel.Container();
            this.AddButton = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.ArticleNameLabel = new System.Windows.Forms.Label();
            this.ArticleTextTB = new System.Windows.Forms.TextBox();
            this.TagsLabel = new System.Windows.Forms.Label();
            this.TagsTB = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TopicLabel = new System.Windows.Forms.Label();
            this.TopicTB = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddButton.Location = new System.Drawing.Point(0, 450);
            this.AddButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(849, 43);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Сохранить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(119, 6);
            this.NameTB.Margin = new System.Windows.Forms.Padding(5);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(718, 29);
            this.NameTB.TabIndex = 1;
            // 
            // ArticleNameLabel
            // 
            this.ArticleNameLabel.AutoSize = true;
            this.ArticleNameLabel.Location = new System.Drawing.Point(14, 9);
            this.ArticleNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ArticleNameLabel.Name = "ArticleNameLabel";
            this.ArticleNameLabel.Size = new System.Drawing.Size(97, 24);
            this.ArticleNameLabel.TabIndex = 2;
            this.ArticleNameLabel.Text = "Название";
            // 
            // ArticleTextTB
            // 
            this.ArticleTextTB.Location = new System.Drawing.Point(12, 112);
            this.ArticleTextTB.Multiline = true;
            this.ArticleTextTB.Name = "ArticleTextTB";
            this.ArticleTextTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArticleTextTB.Size = new System.Drawing.Size(825, 330);
            this.ArticleTextTB.TabIndex = 3;
            // 
            // TagsLabel
            // 
            this.TagsLabel.AutoSize = true;
            this.TagsLabel.Location = new System.Drawing.Point(14, 46);
            this.TagsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TagsLabel.Name = "TagsLabel";
            this.TagsLabel.Size = new System.Drawing.Size(53, 24);
            this.TagsLabel.TabIndex = 4;
            this.TagsLabel.Text = "Теги";
            // 
            // TagsTB
            // 
            this.TagsTB.Location = new System.Drawing.Point(119, 43);
            this.TagsTB.Name = "TagsTB";
            this.TagsTB.Size = new System.Drawing.Size(383, 29);
            this.TagsTB.TabIndex = 5;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "Теги пишутся через запятую с пробелом, без решётки";
            // 
            // TopicLabel
            // 
            this.TopicLabel.AutoSize = true;
            this.TopicLabel.Location = new System.Drawing.Point(510, 46);
            this.TopicLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(56, 24);
            this.TopicLabel.TabIndex = 6;
            this.TopicLabel.Text = "Тема";
            // 
            // TopicTB
            // 
            this.TopicTB.Location = new System.Drawing.Point(574, 43);
            this.TopicTB.Name = "TopicTB";
            this.TopicTB.Size = new System.Drawing.Size(263, 29);
            this.TopicTB.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(119, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(414, 28);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Использовать форматирование MarkDown";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AddArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 493);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TopicTB);
            this.Controls.Add(this.TopicLabel);
            this.Controls.Add(this.TagsTB);
            this.Controls.Add(this.TagsLabel);
            this.Controls.Add(this.ArticleTextTB);
            this.Controls.Add(this.ArticleNameLabel);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.AddButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddArticle";
            this.Text = "Добавить статью";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label ArticleNameLabel;
        private System.Windows.Forms.TextBox ArticleTextTB;
        private System.Windows.Forms.Label TagsLabel;
        private System.Windows.Forms.TextBox TagsTB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label TopicLabel;
        private System.Windows.Forms.TextBox TopicTB;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}