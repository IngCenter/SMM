namespace WindowsFormsApp2
{
    partial class Search
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
            this.filterPanel = new System.Windows.Forms.Panel();
            this.TopicFilterBox = new System.Windows.Forms.ComboBox();
            this.AuthorFilterBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TagFilterBox = new System.Windows.Forms.ComboBox();
            this.findButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.TopicFilterBox);
            this.filterPanel.Controls.Add(this.AuthorFilterBox);
            this.filterPanel.Controls.Add(this.label5);
            this.filterPanel.Controls.Add(this.label4);
            this.filterPanel.Controls.Add(this.label3);
            this.filterPanel.Controls.Add(this.label1);
            this.filterPanel.Controls.Add(this.TagFilterBox);
            this.filterPanel.Controls.Add(this.findButton);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(972, 104);
            this.filterPanel.TabIndex = 4;
            // 
            // TopicFilterBox
            // 
            this.TopicFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TopicFilterBox.FormattingEnabled = true;
            this.TopicFilterBox.Location = new System.Drawing.Point(312, 59);
            this.TopicFilterBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TopicFilterBox.Name = "TopicFilterBox";
            this.TopicFilterBox.Size = new System.Drawing.Size(178, 33);
            this.TopicFilterBox.TabIndex = 5;
            // 
            // AuthorFilterBox
            // 
            this.AuthorFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorFilterBox.FormattingEnabled = true;
            this.AuthorFilterBox.Location = new System.Drawing.Point(578, 65);
            this.AuthorFilterBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AuthorFilterBox.Name = "AuthorFilterBox";
            this.AuthorFilterBox.Size = new System.Drawing.Size(185, 33);
            this.AuthorFilterBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Автор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Темы";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(850, 58);
            this.label3.TabIndex = 0;
            this.label3.Text = "Все статьи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Теги";
            // 
            // TagFilterBox
            // 
            this.TagFilterBox.Location = new System.Drawing.Point(71, 59);
            this.TagFilterBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TagFilterBox.Name = "TagFilterBox";
            this.TagFilterBox.Size = new System.Drawing.Size(154, 33);
            this.TagFilterBox.TabIndex = 2;
            this.TagFilterBox.SelectedIndexChanged += new System.EventHandler(this.TagFilterBox_SelectedIndexChanged);
            // 
            // findButton
            // 
            this.findButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.findButton.Location = new System.Drawing.Point(850, 0);
            this.findButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(122, 104);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Поиск";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 399);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.filterPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(972, 503);
            this.Load += new System.EventHandler(this.Search_Load);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.ComboBox TopicFilterBox;
        private System.Windows.Forms.ComboBox AuthorFilterBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TagFilterBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Panel panel1;
    }
}