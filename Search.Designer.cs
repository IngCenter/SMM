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
            this.label3 = new System.Windows.Forms.Label();
            this.FilterTB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TopicFilterBox = new System.Windows.Forms.ComboBox();
            this.AuthorFilterBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(799, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Все статьи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FilterTB
            // 
            this.FilterTB.Location = new System.Drawing.Point(12, 4);
            this.FilterTB.Name = "FilterTB";
            this.FilterTB.Size = new System.Drawing.Size(316, 22);
            this.FilterTB.TabIndex = 3;
            this.FilterTB.TextChanged += new System.EventHandler(this.FilterTB_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.comboBox1.Items.AddRange(new object[] {
            "Кухня"});
            this.comboBox1.Location = new System.Drawing.Point(469, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // TopicFilterBox
            // 
            this.TopicFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TopicFilterBox.FormattingEnabled = true;
            this.TopicFilterBox.Location = new System.Drawing.Point(74, 35);
            this.TopicFilterBox.Name = "TopicFilterBox";
            this.TopicFilterBox.Size = new System.Drawing.Size(186, 24);
            this.TopicFilterBox.TabIndex = 11;
            // 
            // AuthorFilterBox
            // 
            this.AuthorFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorFilterBox.FormattingEnabled = true;
            this.AuthorFilterBox.Location = new System.Drawing.Point(319, 34);
            this.AuthorFilterBox.Name = "AuthorFilterBox";
            this.AuthorFilterBox.Size = new System.Drawing.Size(162, 24);
            this.AuthorFilterBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Автор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Темы";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(498, 34);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(280, 25);
            this.findButton.TabIndex = 14;
            this.findButton.Text = "Поиск";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.TopicFilterBox);
            this.Controls.Add(this.AuthorFilterBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.FilterTB);
            this.Controls.Add(this.label3);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FilterTB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox TopicFilterBox;
        private System.Windows.Forms.ComboBox AuthorFilterBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button findButton;
    }
}