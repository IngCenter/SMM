namespace WindowsFormsApp2
{
    partial class Comments
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
            this.CommLable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CommLable
            // 
            this.CommLable.Location = new System.Drawing.Point(1, 2);
            this.CommLable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CommLable.Multiline = true;
            this.CommLable.Name = "CommLable";
            this.CommLable.ReadOnly = true;
            this.CommLable.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CommLable.Size = new System.Drawing.Size(590, 392);
            this.CommLable.TabIndex = 6;
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 328);
            this.Controls.Add(this.CommLable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Comments";
            this.Text = "Комментарии";
            this.Load += new System.EventHandler(this.Comments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CommLable;
    }
}