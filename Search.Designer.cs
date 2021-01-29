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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TopicFilterBox = new System.Windows.Forms.ComboBox();
            this.FilterTB = new System.Windows.Forms.TextBox();
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
            this.filterPanel.Controls.Add(this.comboBox1);
            this.filterPanel.Controls.Add(this.TopicFilterBox);
            this.filterPanel.Controls.Add(this.FilterTB);
            this.filterPanel.Controls.Add(this.AuthorFilterBox);
            this.filterPanel.Controls.Add(this.label5);
            this.filterPanel.Controls.Add(this.label4);
            this.filterPanel.Controls.Add(this.label3);
            this.filterPanel.Controls.Add(this.label1);
            this.filterPanel.Controls.Add(this.TagFilterBox);
            this.filterPanel.Controls.Add(this.findButton);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(865, 73);
            this.filterPanel.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.comboBox1.Items.AddRange(new object[] {
            "Кухня"});
            this.comboBox1.Location = new System.Drawing.Point(462, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // TopicFilterBox
            // 
            this.TopicFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TopicFilterBox.FormattingEnabled = true;
            this.TopicFilterBox.Location = new System.Drawing.Point(326, 38);
            this.TopicFilterBox.Name = "TopicFilterBox";
            this.TopicFilterBox.Size = new System.Drawing.Size(186, 24);
            this.TopicFilterBox.TabIndex = 5;
            // 
            // FilterTB
            // 
            this.FilterTB.Location = new System.Drawing.Point(6, 3);
            this.FilterTB.Name = "FilterTB";
            this.FilterTB.Size = new System.Drawing.Size(316, 22);
            this.FilterTB.TabIndex = 2;
            this.FilterTB.TextChanged += new System.EventHandler(this.FilterTB_TextChanged);
            // 
            // AuthorFilterBox
            // 
            this.AuthorFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorFilterBox.FormattingEnabled = true;
            this.AuthorFilterBox.Location = new System.Drawing.Point(609, 37);
            this.AuthorFilterBox.Name = "AuthorFilterBox";
            this.AuthorFilterBox.Size = new System.Drawing.Size(162, 24);
            this.AuthorFilterBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Автор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Темы";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(784, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Все статьи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Теги";
            // 
            // TagFilterBox
            // 
            this.TagFilterBox.Location = new System.Drawing.Point(66, 38);
            this.TagFilterBox.Name = "TagFilterBox";
            this.TagFilterBox.Size = new System.Drawing.Size(189, 24);
            this.TagFilterBox.TabIndex = 2;
            // 
            // findButton
            // 
            this.findButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.findButton.Location = new System.Drawing.Point(784, 0);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(81, 73);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Поиск";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 377);
            this.panel1.TabIndex = 5;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.filterPanel);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox TopicFilterBox;
        private System.Windows.Forms.TextBox FilterTB;
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