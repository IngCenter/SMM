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
            this.SuspendLayout();
            // 
            // UserArticlesPanel
            // 
            this.UserArticlesPanel.AutoScroll = true;
            this.UserArticlesPanel.Location = new System.Drawing.Point(3, 1);
            this.UserArticlesPanel.Name = "UserArticlesPanel";
            this.UserArticlesPanel.Size = new System.Drawing.Size(919, 464);
            this.UserArticlesPanel.TabIndex = 0;
            this.UserArticlesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UserArticlesPanel_Paint);
            // 
            // UserArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 468);
            this.Controls.Add(this.UserArticlesPanel);
            this.Name = "UserArticles";
            this.Text = "UserArticles";
            this.Load += new System.EventHandler(this.UserArticles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserArticlesPanel;
    }
}