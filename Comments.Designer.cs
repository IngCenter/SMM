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
            this.CommLable.Multiline = true;
            this.CommLable.Name = "CommLable";
            this.CommLable.ReadOnly = true;
            this.CommLable.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CommLable.Size = new System.Drawing.Size(785, 482);
            this.CommLable.TabIndex = 6;
         //   this.CommLable.TextChanged += new System.EventHandler(this.CommLable_TextChanged);
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 486);
            this.Controls.Add(this.CommLable);
            this.Name = "Comments";
            this.Text = "Comments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CommLable;
    }
}