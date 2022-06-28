namespace Practice_Transport
{
    partial class CalculationForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OtkudaLabel = new System.Windows.Forms.Label();
            this.KudaLabel = new System.Windows.Forms.Label();
            this.OtkudaComboBox = new System.Windows.Forms.ComboBox();
            this.KudaComboBox = new System.Windows.Forms.ComboBox();
            this.ToDoorCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BoxberryDateLabel = new System.Windows.Forms.Label();
            this.DPDDateLabel = new System.Windows.Forms.Label();
            this.SDEKDateLabel = new System.Windows.Forms.Label();
            this.BoxberryPriceLabel = new System.Windows.Forms.Label();
            this.DPDPriceLabel = new System.Windows.Forms.Label();
            this.SDEKPriceLabel = new System.Windows.Forms.Label();
            this.BoxberryZakazButton = new System.Windows.Forms.Button();
            this.DPDZakazButton = new System.Windows.Forms.Button();
            this.SDEKZakazButton = new System.Windows.Forms.Button();
            this.FromDoorCheckBox = new System.Windows.Forms.CheckBox();
            this.ZakazListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(244, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(270, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Калькулятор доставки";
            // 
            // OtkudaLabel
            // 
            this.OtkudaLabel.AutoSize = true;
            this.OtkudaLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtkudaLabel.Location = new System.Drawing.Point(37, 72);
            this.OtkudaLabel.Name = "OtkudaLabel";
            this.OtkudaLabel.Size = new System.Drawing.Size(67, 21);
            this.OtkudaLabel.TabIndex = 1;
            this.OtkudaLabel.Text = "Откуда";
            // 
            // KudaLabel
            // 
            this.KudaLabel.AutoSize = true;
            this.KudaLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KudaLabel.Location = new System.Drawing.Point(448, 72);
            this.KudaLabel.Name = "KudaLabel";
            this.KudaLabel.Size = new System.Drawing.Size(48, 21);
            this.KudaLabel.TabIndex = 2;
            this.KudaLabel.Text = "Куда";
            // 
            // OtkudaComboBox
            // 
            this.OtkudaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OtkudaComboBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtkudaComboBox.FormattingEnabled = true;
            this.OtkudaComboBox.Items.AddRange(new object[] {
            "Москва",
            "Казань",
            "Самара",
            "Санкт-Петербург"});
            this.OtkudaComboBox.Location = new System.Drawing.Point(41, 105);
            this.OtkudaComboBox.Name = "OtkudaComboBox";
            this.OtkudaComboBox.Size = new System.Drawing.Size(166, 29);
            this.OtkudaComboBox.TabIndex = 3;
            // 
            // KudaComboBox
            // 
            this.KudaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KudaComboBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KudaComboBox.FormattingEnabled = true;
            this.KudaComboBox.Items.AddRange(new object[] {
            "Ульяновск"});
            this.KudaComboBox.Location = new System.Drawing.Point(452, 105);
            this.KudaComboBox.Name = "KudaComboBox";
            this.KudaComboBox.Size = new System.Drawing.Size(166, 29);
            this.KudaComboBox.TabIndex = 4;
            // 
            // ToDoorCheckBox
            // 
            this.ToDoorCheckBox.AutoSize = true;
            this.ToDoorCheckBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDoorCheckBox.Location = new System.Drawing.Point(452, 143);
            this.ToDoorCheckBox.Name = "ToDoorCheckBox";
            this.ToDoorCheckBox.Size = new System.Drawing.Size(104, 25);
            this.ToDoorCheckBox.TabIndex = 6;
            this.ToDoorCheckBox.Text = "До двери";
            this.ToDoorCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Длина, см";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(163, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ширина, см";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(306, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Высота, см";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(448, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вес, кг";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthTextBox.Location = new System.Drawing.Point(41, 229);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 29);
            this.LengthTextBox.TabIndex = 11;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthTextBox.Location = new System.Drawing.Point(167, 229);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 29);
            this.WidthTextBox.TabIndex = 12;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightTextBox.Location = new System.Drawing.Point(310, 229);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 29);
            this.HeightTextBox.TabIndex = 13;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightTextBox.Location = new System.Drawing.Point(452, 229);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 29);
            this.WeightTextBox.TabIndex = 14;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.Lime;
            this.CalculateButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(41, 290);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(120, 37);
            this.CalculateButton.TabIndex = 15;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(163, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Дата доставки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(338, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Цена, руб.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(448, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Заказать";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Компания";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(41, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Boxberry";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(41, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "DPD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(41, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "СДЭК";
            // 
            // BoxberryDateLabel
            // 
            this.BoxberryDateLabel.AutoSize = true;
            this.BoxberryDateLabel.BackColor = System.Drawing.Color.White;
            this.BoxberryDateLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxberryDateLabel.Location = new System.Drawing.Point(163, 400);
            this.BoxberryDateLabel.Name = "BoxberryDateLabel";
            this.BoxberryDateLabel.Size = new System.Drawing.Size(47, 21);
            this.BoxberryDateLabel.TabIndex = 19;
            this.BoxberryDateLabel.Text = "Дата";
            this.BoxberryDateLabel.Visible = false;
            // 
            // DPDDateLabel
            // 
            this.DPDDateLabel.AutoSize = true;
            this.DPDDateLabel.BackColor = System.Drawing.Color.White;
            this.DPDDateLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DPDDateLabel.Location = new System.Drawing.Point(163, 448);
            this.DPDDateLabel.Name = "DPDDateLabel";
            this.DPDDateLabel.Size = new System.Drawing.Size(47, 21);
            this.DPDDateLabel.TabIndex = 20;
            this.DPDDateLabel.Text = "Дата";
            this.DPDDateLabel.Visible = false;
            // 
            // SDEKDateLabel
            // 
            this.SDEKDateLabel.AutoSize = true;
            this.SDEKDateLabel.BackColor = System.Drawing.Color.White;
            this.SDEKDateLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SDEKDateLabel.Location = new System.Drawing.Point(163, 499);
            this.SDEKDateLabel.Name = "SDEKDateLabel";
            this.SDEKDateLabel.Size = new System.Drawing.Size(47, 21);
            this.SDEKDateLabel.TabIndex = 21;
            this.SDEKDateLabel.Text = "Дата";
            this.SDEKDateLabel.Visible = false;
            // 
            // BoxberryPriceLabel
            // 
            this.BoxberryPriceLabel.AutoSize = true;
            this.BoxberryPriceLabel.BackColor = System.Drawing.Color.White;
            this.BoxberryPriceLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxberryPriceLabel.Location = new System.Drawing.Point(338, 400);
            this.BoxberryPriceLabel.Name = "BoxberryPriceLabel";
            this.BoxberryPriceLabel.Size = new System.Drawing.Size(49, 21);
            this.BoxberryPriceLabel.TabIndex = 22;
            this.BoxberryPriceLabel.Text = "Цена";
            this.BoxberryPriceLabel.Visible = false;
            // 
            // DPDPriceLabel
            // 
            this.DPDPriceLabel.AutoSize = true;
            this.DPDPriceLabel.BackColor = System.Drawing.Color.White;
            this.DPDPriceLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DPDPriceLabel.Location = new System.Drawing.Point(338, 448);
            this.DPDPriceLabel.Name = "DPDPriceLabel";
            this.DPDPriceLabel.Size = new System.Drawing.Size(49, 21);
            this.DPDPriceLabel.TabIndex = 23;
            this.DPDPriceLabel.Text = "Цена";
            this.DPDPriceLabel.Visible = false;
            // 
            // SDEKPriceLabel
            // 
            this.SDEKPriceLabel.AutoSize = true;
            this.SDEKPriceLabel.BackColor = System.Drawing.Color.White;
            this.SDEKPriceLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SDEKPriceLabel.Location = new System.Drawing.Point(338, 499);
            this.SDEKPriceLabel.Name = "SDEKPriceLabel";
            this.SDEKPriceLabel.Size = new System.Drawing.Size(49, 21);
            this.SDEKPriceLabel.TabIndex = 24;
            this.SDEKPriceLabel.Text = "Цена";
            this.SDEKPriceLabel.Visible = false;
            // 
            // BoxberryZakazButton
            // 
            this.BoxberryZakazButton.BackColor = System.Drawing.Color.Lime;
            this.BoxberryZakazButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxberryZakazButton.Location = new System.Drawing.Point(452, 400);
            this.BoxberryZakazButton.Name = "BoxberryZakazButton";
            this.BoxberryZakazButton.Size = new System.Drawing.Size(100, 33);
            this.BoxberryZakazButton.TabIndex = 25;
            this.BoxberryZakazButton.Text = "Заказать";
            this.BoxberryZakazButton.UseVisualStyleBackColor = false;
            this.BoxberryZakazButton.Visible = false;
            this.BoxberryZakazButton.Click += new System.EventHandler(this.BoxberryZakazButton_Click);
            // 
            // DPDZakazButton
            // 
            this.DPDZakazButton.BackColor = System.Drawing.Color.Lime;
            this.DPDZakazButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DPDZakazButton.Location = new System.Drawing.Point(452, 448);
            this.DPDZakazButton.Name = "DPDZakazButton";
            this.DPDZakazButton.Size = new System.Drawing.Size(100, 33);
            this.DPDZakazButton.TabIndex = 26;
            this.DPDZakazButton.Text = "Заказать";
            this.DPDZakazButton.UseVisualStyleBackColor = false;
            this.DPDZakazButton.Visible = false;
            this.DPDZakazButton.Click += new System.EventHandler(this.DPDZakazButton_Click);
            // 
            // SDEKZakazButton
            // 
            this.SDEKZakazButton.BackColor = System.Drawing.Color.Lime;
            this.SDEKZakazButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SDEKZakazButton.Location = new System.Drawing.Point(452, 499);
            this.SDEKZakazButton.Name = "SDEKZakazButton";
            this.SDEKZakazButton.Size = new System.Drawing.Size(100, 33);
            this.SDEKZakazButton.TabIndex = 27;
            this.SDEKZakazButton.Text = "Заказать";
            this.SDEKZakazButton.UseVisualStyleBackColor = false;
            this.SDEKZakazButton.Visible = false;
            this.SDEKZakazButton.Click += new System.EventHandler(this.SDEKZakazButton_Click);
            // 
            // FromDoorCheckBox
            // 
            this.FromDoorCheckBox.AutoSize = true;
            this.FromDoorCheckBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromDoorCheckBox.Location = new System.Drawing.Point(41, 143);
            this.FromDoorCheckBox.Name = "FromDoorCheckBox";
            this.FromDoorCheckBox.Size = new System.Drawing.Size(103, 25);
            this.FromDoorCheckBox.TabIndex = 28;
            this.FromDoorCheckBox.Text = "От двери";
            this.FromDoorCheckBox.UseVisualStyleBackColor = true;
            // 
            // ZakazListButton
            // 
            this.ZakazListButton.BackColor = System.Drawing.Color.Lime;
            this.ZakazListButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZakazListButton.Location = new System.Drawing.Point(739, 12);
            this.ZakazListButton.Name = "ZakazListButton";
            this.ZakazListButton.Size = new System.Drawing.Size(120, 55);
            this.ZakazListButton.TabIndex = 29;
            this.ZakazListButton.Text = "Список заказов";
            this.ZakazListButton.UseVisualStyleBackColor = false;
            this.ZakazListButton.Click += new System.EventHandler(this.ZakazListButton_Click);
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 615);
            this.Controls.Add(this.ZakazListButton);
            this.Controls.Add(this.FromDoorCheckBox);
            this.Controls.Add(this.SDEKZakazButton);
            this.Controls.Add(this.DPDZakazButton);
            this.Controls.Add(this.BoxberryZakazButton);
            this.Controls.Add(this.SDEKPriceLabel);
            this.Controls.Add(this.DPDPriceLabel);
            this.Controls.Add(this.BoxberryPriceLabel);
            this.Controls.Add(this.SDEKDateLabel);
            this.Controls.Add(this.DPDDateLabel);
            this.Controls.Add(this.BoxberryDateLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToDoorCheckBox);
            this.Controls.Add(this.KudaComboBox);
            this.Controls.Add(this.OtkudaComboBox);
            this.Controls.Add(this.KudaLabel);
            this.Controls.Add(this.OtkudaLabel);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CalculationForm";
            this.Text = "Калькулятор доставки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label OtkudaLabel;
        private System.Windows.Forms.Label KudaLabel;
        private System.Windows.Forms.ComboBox OtkudaComboBox;
        private System.Windows.Forms.ComboBox KudaComboBox;
        private System.Windows.Forms.CheckBox ToDoorCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label BoxberryDateLabel;
        private System.Windows.Forms.Label DPDDateLabel;
        private System.Windows.Forms.Label SDEKDateLabel;
        private System.Windows.Forms.Label BoxberryPriceLabel;
        private System.Windows.Forms.Label DPDPriceLabel;
        private System.Windows.Forms.Label SDEKPriceLabel;
        private System.Windows.Forms.Button BoxberryZakazButton;
        private System.Windows.Forms.Button DPDZakazButton;
        private System.Windows.Forms.Button SDEKZakazButton;
        private System.Windows.Forms.CheckBox FromDoorCheckBox;
        private System.Windows.Forms.Button ZakazListButton;
    }
}

