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
            this.AddButton = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.ArticleNameLabel = new System.Windows.Forms.Label();
            this.ArticleTextTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddButton.Location = new System.Drawing.Point(0, 418);
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
            this.NameTB.Location = new System.Drawing.Point(121, 6);
            this.NameTB.Margin = new System.Windows.Forms.Padding(5);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(716, 29);
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
            this.ArticleTextTB.Location = new System.Drawing.Point(18, 43);
            this.ArticleTextTB.Multiline = true;
            this.ArticleTextTB.Name = "ArticleTextTB";
            this.ArticleTextTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArticleTextTB.Size = new System.Drawing.Size(819, 367);
            this.ArticleTextTB.TabIndex = 3;
            // 
            // AddArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 461);
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
    }
}