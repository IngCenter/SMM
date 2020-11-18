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
            this.button1 = new System.Windows.Forms.Button();
            this.DislikePB = new System.Windows.Forms.PictureBox();
            this.CommPB = new System.Windows.Forms.PictureBox();
            this.LikePB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DislikePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nameLabel.Location = new System.Drawing.Point(11, 9);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(530, 49);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label1";
            // 
            // textLabel
            // 
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(9, 60);
            this.textLabel.Margin = new System.Windows.Forms.Padding(2);
            this.textLabel.Multiline = true;
            this.textLabel.Name = "textLabel";
            this.textLabel.ReadOnly = true;
            this.textLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLabel.Size = new System.Drawing.Size(714, 309);
            this.textLabel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 386);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Нравится";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 386);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Не нравится";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DislikePB
            // 
            this.DislikePB.Image = global::WindowsFormsApp2.Properties.Resources.DisLikeOff;
            this.DislikePB.Location = new System.Drawing.Point(105, 373);
            this.DislikePB.Margin = new System.Windows.Forms.Padding(2);
            this.DislikePB.Name = "DislikePB";
            this.DislikePB.Size = new System.Drawing.Size(32, 35);
            this.DislikePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DislikePB.TabIndex = 9;
            this.DislikePB.TabStop = false;
            this.DislikePB.Tag = "1";
            this.DislikePB.Click += new System.EventHandler(this.DislikePB_Click);
            // 
            // CommPB
            // 
            this.CommPB.Image = global::WindowsFormsApp2.Properties.Resources.Comm;
            this.CommPB.Location = new System.Drawing.Point(216, 373);
            this.CommPB.Margin = new System.Windows.Forms.Padding(2);
            this.CommPB.Name = "CommPB";
            this.CommPB.Size = new System.Drawing.Size(44, 35);
            this.CommPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CommPB.TabIndex = 8;
            this.CommPB.TabStop = false;
            this.CommPB.Tag = "1";
            this.CommPB.Click += new System.EventHandler(this.CommPB_Click);
            // 
            // LikePB
            // 
            this.LikePB.Image = global::WindowsFormsApp2.Properties.Resources.LikeOff;
            this.LikePB.Location = new System.Drawing.Point(9, 373);
            this.LikePB.Margin = new System.Windows.Forms.Padding(2);
            this.LikePB.Name = "LikePB";
            this.LikePB.Size = new System.Drawing.Size(32, 35);
            this.LikePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LikePB.TabIndex = 4;
            this.LikePB.TabStop = false;
            this.LikePB.Tag = "1";
            this.LikePB.Click += new System.EventHandler(this.LikePB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(699, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "сохранить";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 419);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DislikePB);
            this.Controls.Add(this.CommPB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.LikePB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ArticleForm";
            this.Text = "Статья";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}