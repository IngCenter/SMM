
namespace ADoors
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.DoorCountChoice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.PlatbandChoice = new System.Windows.Forms.CheckBox();
            this.DoorHandleChoice = new System.Windows.Forms.CheckBox();
            this.WidthChoice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeChoice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorChoice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModelChoice = new System.Windows.Forms.ComboBox();
            this.DoorPanel = new System.Windows.Forms.Panel();
            this.DoorPB = new System.Windows.Forms.PictureBox();
            this.CostInfoPanel = new System.Windows.Forms.Panel();
            this.Textpricelabel = new System.Windows.Forms.Label();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.OptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoorCountChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthChoice)).BeginInit();
            this.DoorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoorPB)).BeginInit();
            this.CostInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BackColor = System.Drawing.Color.Peru;
            this.OptionsPanel.Controls.Add(this.ComputeButton);
            this.OptionsPanel.Controls.Add(this.DoorCountChoice);
            this.OptionsPanel.Controls.Add(this.label5);
            this.OptionsPanel.Controls.Add(this.PlatbandChoice);
            this.OptionsPanel.Controls.Add(this.DoorHandleChoice);
            this.OptionsPanel.Controls.Add(this.WidthChoice);
            this.OptionsPanel.Controls.Add(this.label4);
            this.OptionsPanel.Controls.Add(this.TypeChoice);
            this.OptionsPanel.Controls.Add(this.label3);
            this.OptionsPanel.Controls.Add(this.ColorChoice);
            this.OptionsPanel.Controls.Add(this.label2);
            this.OptionsPanel.Controls.Add(this.label1);
            this.OptionsPanel.Controls.Add(this.ModelChoice);
            this.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OptionsPanel.Location = new System.Drawing.Point(0, 0);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(200, 216);
            this.OptionsPanel.TabIndex = 0;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComputeButton.Location = new System.Drawing.Point(0, 193);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(200, 23);
            this.ComputeButton.TabIndex = 12;
            this.ComputeButton.Text = "Рассчитать!";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // DoorCountChoice
            // 
            this.DoorCountChoice.Location = new System.Drawing.Point(90, 157);
            this.DoorCountChoice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DoorCountChoice.Name = "DoorCountChoice";
            this.DoorCountChoice.Size = new System.Drawing.Size(107, 20);
            this.DoorCountChoice.TabIndex = 11;
            this.DoorCountChoice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DoorCountChoice.ValueChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кол-во дверей";
            // 
            // PlatbandChoice
            // 
            this.PlatbandChoice.AutoSize = true;
            this.PlatbandChoice.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlatbandChoice.Location = new System.Drawing.Point(3, 135);
            this.PlatbandChoice.Name = "PlatbandChoice";
            this.PlatbandChoice.Size = new System.Drawing.Size(75, 17);
            this.PlatbandChoice.TabIndex = 9;
            this.PlatbandChoice.Text = "Наличник";
            this.PlatbandChoice.UseVisualStyleBackColor = true;
            this.PlatbandChoice.CheckStateChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // DoorHandleChoice
            // 
            this.DoorHandleChoice.AutoSize = true;
            this.DoorHandleChoice.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DoorHandleChoice.Location = new System.Drawing.Point(3, 112);
            this.DoorHandleChoice.Name = "DoorHandleChoice";
            this.DoorHandleChoice.Size = new System.Drawing.Size(73, 17);
            this.DoorHandleChoice.TabIndex = 8;
            this.DoorHandleChoice.Text = "Ручка      ";
            this.DoorHandleChoice.UseVisualStyleBackColor = true;
            this.DoorHandleChoice.CheckStateChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // WidthChoice
            // 
            this.WidthChoice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.WidthChoice.Location = new System.Drawing.Point(56, 86);
            this.WidthChoice.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.WidthChoice.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.WidthChoice.Name = "WidthChoice";
            this.WidthChoice.Size = new System.Drawing.Size(141, 20);
            this.WidthChoice.TabIndex = 7;
            this.WidthChoice.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.WidthChoice.ValueChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ширина";
            // 
            // TypeChoice
            // 
            this.TypeChoice.FormattingEnabled = true;
            this.TypeChoice.Items.AddRange(new object[] {
            "Без стеклянных элементов",
            "Частично остеклённый",
            "Остеклённый",
            "Частично остеклённый (Матовое стекло)",
            "Остеклённый (Матовое стекло)",
            "Частично остеклённый (Искажённое стекло)",
            "Остеклённый (Искажённое стекло)"});
            this.TypeChoice.Location = new System.Drawing.Point(55, 59);
            this.TypeChoice.Name = "TypeChoice";
            this.TypeChoice.Size = new System.Drawing.Size(142, 21);
            this.TypeChoice.TabIndex = 5;
            this.TypeChoice.SelectedIndexChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип";
            // 
            // ColorChoice
            // 
            this.ColorChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorChoice.FormattingEnabled = true;
            this.ColorChoice.Items.AddRange(new object[] {
            "Эмаль",
            "Бреннерский орех",
            "Венге"});
            this.ColorChoice.Location = new System.Drawing.Point(55, 34);
            this.ColorChoice.Name = "ColorChoice";
            this.ColorChoice.Size = new System.Drawing.Size(142, 21);
            this.ColorChoice.TabIndex = 3;
            this.ColorChoice.SelectedIndexChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цвет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Модель";
            // 
            // ModelChoice
            // 
            this.ModelChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelChoice.FormattingEnabled = true;
            this.ModelChoice.Items.AddRange(new object[] {
            "Леонардо",
            "Трио",
            "Черчилль",
            "Рузвельт",
            "Маргарет"});
            this.ModelChoice.Location = new System.Drawing.Point(55, 6);
            this.ModelChoice.Name = "ModelChoice";
            this.ModelChoice.Size = new System.Drawing.Size(142, 21);
            this.ModelChoice.TabIndex = 0;
            this.ModelChoice.SelectedIndexChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // DoorPanel
            // 
            this.DoorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DoorPanel.Controls.Add(this.DoorPB);
            this.DoorPanel.Controls.Add(this.CostInfoPanel);
            this.DoorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoorPanel.Location = new System.Drawing.Point(200, 0);
            this.DoorPanel.Name = "DoorPanel";
            this.DoorPanel.Size = new System.Drawing.Size(260, 216);
            this.DoorPanel.TabIndex = 1;
            // 
            // DoorPB
            // 
            this.DoorPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoorPB.Image = global::ADoors.Properties.Resources.door_cherchill;
            this.DoorPB.Location = new System.Drawing.Point(0, 0);
            this.DoorPB.Margin = new System.Windows.Forms.Padding(2);
            this.DoorPB.Name = "DoorPB";
            this.DoorPB.Size = new System.Drawing.Size(260, 196);
            this.DoorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DoorPB.TabIndex = 2;
            this.DoorPB.TabStop = false;
            // 
            // CostInfoPanel
            // 
            this.CostInfoPanel.Controls.Add(this.Textpricelabel);
            this.CostInfoPanel.Controls.Add(this.Pricelabel);
            this.CostInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CostInfoPanel.Location = new System.Drawing.Point(0, 196);
            this.CostInfoPanel.Name = "CostInfoPanel";
            this.CostInfoPanel.Size = new System.Drawing.Size(260, 20);
            this.CostInfoPanel.TabIndex = 3;
            // 
            // Textpricelabel
            // 
            this.Textpricelabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Textpricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textpricelabel.Location = new System.Drawing.Point(0, 0);
            this.Textpricelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Textpricelabel.Name = "Textpricelabel";
            this.Textpricelabel.Size = new System.Drawing.Size(99, 20);
            this.Textpricelabel.TabIndex = 1;
            this.Textpricelabel.Text = "Итоговая цена:";
            this.Textpricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pricelabel
            // 
            this.Pricelabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pricelabel.Location = new System.Drawing.Point(103, 0);
            this.Pricelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(157, 20);
            this.Pricelabel.TabIndex = 0;
            this.Pricelabel.Text = "нажмите \"Рассчитать!\"";
            this.Pricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 216);
            this.Controls.Add(this.DoorPanel);
            this.Controls.Add(this.OptionsPanel);
            this.Name = "MainForm";
            this.Text = "Калькулятор стоимости двери";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoorCountChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthChoice)).EndInit();
            this.DoorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoorPB)).EndInit();
            this.CostInfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ModelChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox PlatbandChoice;
        private System.Windows.Forms.CheckBox DoorHandleChoice;
        private System.Windows.Forms.NumericUpDown WidthChoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypeChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ColorChoice;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.NumericUpDown DoorCountChoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel DoorPanel;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.Label Textpricelabel;
        private System.Windows.Forms.PictureBox DoorPB;
        private System.Windows.Forms.Panel CostInfoPanel;
    }
}

