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
            this.AddLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserArticlesPanel
            // 
            this.UserArticlesPanel.AutoScroll = true;
            this.UserArticlesPanel.Location = new System.Drawing.Point(3, 39);
            this.UserArticlesPanel.Name = "UserArticlesPanel";
            this.UserArticlesPanel.Size = new System.Drawing.Size(913, 426);
            this.UserArticlesPanel.TabIndex = 0;
            this.UserArticlesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UserArticlesPanel_Paint);
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLabel.Location = new System.Drawing.Point(12, 9);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(130, 18);
            this.AddLabel.TabIndex = 1;
            this.AddLabel.Text = "Добавить статью";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(153, 6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(30, 27);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UserArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 468);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.UserArticlesPanel);
            this.Name = "UserArticles";
            this.Text = "UserArticles";
            this.Load += new System.EventHandler(this.UserArticles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UserArticlesPanel;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Button AddButton;
    }
}