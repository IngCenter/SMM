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
            this.textLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DislikePB = new System.Windows.Forms.PictureBox();
            this.CommPB = new System.Windows.Forms.PictureBox();
            this.LikePB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DislikePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nameLabel.Location = new System.Drawing.Point(15, 11);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(904, 52);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label1";
            // 
            // textLabel
            // 
            this.textLabel.Location = new System.Drawing.Point(12, 65);
            this.textLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textLabel.Multiline = true;
            this.textLabel.Name = "textLabel";
            this.textLabel.ReadOnly = true;
            this.textLabel.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLabel.Size = new System.Drawing.Size(905, 379);
            this.textLabel.TabIndex = 5;
            this.textLabel.TextChanged += new System.EventHandler(this.textLabel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Нравится";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Не нравится";
            // 
            // DislikePB
            // 
            this.DislikePB.Image = global::WindowsFormsApp2.Properties.Resources.DisLikeOff;
            this.DislikePB.Location = new System.Drawing.Point(140, 450);
            this.DislikePB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DislikePB.Name = "DislikePB";
            this.DislikePB.Size = new System.Drawing.Size(43, 43);
            this.DislikePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DislikePB.TabIndex = 9;
            this.DislikePB.TabStop = false;
            this.DislikePB.Tag = "1";
            this.DislikePB.Click += new System.EventHandler(this.DislikePB_Click);
            // 
            // CommPB
            // 
            this.CommPB.Image = global::WindowsFormsApp2.Properties.Resources.Comm;
            this.CommPB.Location = new System.Drawing.Point(288, 450);
            this.CommPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CommPB.Name = "CommPB";
            this.CommPB.Size = new System.Drawing.Size(59, 43);
            this.CommPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CommPB.TabIndex = 8;
            this.CommPB.TabStop = false;
            this.CommPB.Tag = "1";
            this.CommPB.Click += new System.EventHandler(this.CommPB_Click);
            // 
            // LikePB
            // 
            this.LikePB.Image = global::WindowsFormsApp2.Properties.Resources.LikeOff;
            this.LikePB.Location = new System.Drawing.Point(12, 450);
            this.LikePB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LikePB.Name = "LikePB";
            this.LikePB.Size = new System.Drawing.Size(43, 43);
            this.LikePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LikePB.TabIndex = 4;
            this.LikePB.TabStop = false;
            this.LikePB.Tag = "1";
            this.LikePB.Click += new System.EventHandler(this.LikePB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(933, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(979, 506);
            this.Controls.Add(this.DislikePB);
            this.Controls.Add(this.CommPB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.LikePB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ArticleForm";
            this.Text = "Статья";
            this.Load += new System.EventHandler(this.ArticleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DislikePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox LikePB;
        private System.Windows.Forms.TextBox textLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox CommPB;
        private System.Windows.Forms.PictureBox DislikePB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}