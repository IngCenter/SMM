namespace WindowsFormsApp2
{
    partial class ArticleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticleForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.LikePB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LikePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(370, 52);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label1";
            // 
            // textLabel
            // 
            this.textLabel.Location = new System.Drawing.Point(16, 81);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(762, 320);
            this.textLabel.TabIndex = 2;
            this.textLabel.Text = "label2";
            // 
            // LikePB
            // 
            this.LikePB.Image = global::WindowsFormsApp2.Properties.Resources.LikeOff;
            this.LikePB.Location = new System.Drawing.Point(12, 395);
            this.LikePB.Name = "LikePB";
            this.LikePB.Size = new System.Drawing.Size(42, 43);
            this.LikePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LikePB.TabIndex = 4;
            this.LikePB.TabStop = false;
            this.LikePB.Tag = "1";
            this.LikePB.Click += new System.EventHandler(this.LikePB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(389, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LikePB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "ArticleForm";
            this.Text = "Статья";
            this.Load += new System.EventHandler(this.Article_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LikePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox LikePB;
    }
}