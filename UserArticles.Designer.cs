namespace WindowsFormsApp2
{
    partial class UserArticles
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
            this.UserArticlesPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserArticlesPanel
            // 
            this.UserArticlesPanel.AutoScroll = true;
            this.UserArticlesPanel.Location = new System.Drawing.Point(15, 46);
            this.UserArticlesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserArticlesPanel.Name = "UserArticlesPanel";
            this.UserArticlesPanel.Size = new System.Drawing.Size(907, 422);
            this.UserArticlesPanel.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(15, 14);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(195, 27);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "+ Добавить статью";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UserArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 481);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.UserArticlesPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserArticles";
            this.Text = "Пользовательские статьи";
            this.Load += new System.EventHandler(this.UserArticles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserArticlesPanel;
        private System.Windows.Forms.Button AddButton;
    }
}