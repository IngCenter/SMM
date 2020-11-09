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
            this.UserArticlesPanel.Location = new System.Drawing.Point(11, 37);
            this.UserArticlesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserArticlesPanel.Name = "UserArticlesPanel";
            this.UserArticlesPanel.Size = new System.Drawing.Size(680, 343);
            this.UserArticlesPanel.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(11, 11);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(146, 22);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "+ Добавить статью";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UserArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 391);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.UserArticlesPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserArticles";
            this.Text = "Пользовательские статьи";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserArticlesPanel;
        private System.Windows.Forms.Button AddButton;
    }
}