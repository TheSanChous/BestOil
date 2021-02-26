namespace BestOil.Controls
{
    partial class GasStationControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GasStationGroupBox = new System.Windows.Forms.GroupBox();
            this.FinalPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.FinalPriceTypeLabel = new System.Windows.Forms.Label();
            this.FinalPriceLabel = new System.Windows.Forms.Label();
            this.GasQuantityTextBoxLabel = new System.Windows.Forms.Label();
            this.GasPriceTypeTextBoxLabel = new System.Windows.Forms.Label();
            this.GasPriceTextBox = new System.Windows.Forms.TextBox();
            this.GasQuantityTextBox = new System.Windows.Forms.TextBox();
            this.PriceCountTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.CountTypeByPriceRadioButton = new System.Windows.Forms.RadioButton();
            this.CountTypeByQuantityRadioButton = new System.Windows.Forms.RadioButton();
            this.GasPricePanel = new System.Windows.Forms.Panel();
            this.GasPriceTextBoxLabel = new System.Windows.Forms.Label();
            this.GasPriceLabel = new System.Windows.Forms.Label();
            this.GasPriceValueTextBox = new System.Windows.Forms.TextBox();
            this.GasTypePanel = new System.Windows.Forms.Panel();
            this.GasTypeComboBox = new System.Windows.Forms.ComboBox();
            this.GasTypeLabel = new System.Windows.Forms.Label();
            this.GasStationGroupBox.SuspendLayout();
            this.FinalPriceGroupBox.SuspendLayout();
            this.PriceCountTypeGroupBox.SuspendLayout();
            this.GasPricePanel.SuspendLayout();
            this.GasTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GasStationGroupBox
            // 
            this.GasStationGroupBox.Controls.Add(this.FinalPriceGroupBox);
            this.GasStationGroupBox.Controls.Add(this.GasQuantityTextBoxLabel);
            this.GasStationGroupBox.Controls.Add(this.GasPriceTypeTextBoxLabel);
            this.GasStationGroupBox.Controls.Add(this.GasPriceTextBox);
            this.GasStationGroupBox.Controls.Add(this.GasQuantityTextBox);
            this.GasStationGroupBox.Controls.Add(this.PriceCountTypeGroupBox);
            this.GasStationGroupBox.Controls.Add(this.GasPricePanel);
            this.GasStationGroupBox.Controls.Add(this.GasTypePanel);
            this.GasStationGroupBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GasStationGroupBox.Location = new System.Drawing.Point(4, 4);
            this.GasStationGroupBox.Name = "GasStationGroupBox";
            this.GasStationGroupBox.Size = new System.Drawing.Size(240, 273);
            this.GasStationGroupBox.TabIndex = 0;
            this.GasStationGroupBox.TabStop = false;
            this.GasStationGroupBox.Text = "Автозаправка";
            // 
            // FinalPriceGroupBox
            // 
            this.FinalPriceGroupBox.Controls.Add(this.FinalPriceTypeLabel);
            this.FinalPriceGroupBox.Controls.Add(this.FinalPriceLabel);
            this.FinalPriceGroupBox.Location = new System.Drawing.Point(6, 196);
            this.FinalPriceGroupBox.Name = "FinalPriceGroupBox";
            this.FinalPriceGroupBox.Size = new System.Drawing.Size(229, 71);
            this.FinalPriceGroupBox.TabIndex = 5;
            this.FinalPriceGroupBox.TabStop = false;
            this.FinalPriceGroupBox.Text = "К оплате:";
            // 
            // FinalPriceTypeLabel
            // 
            this.FinalPriceTypeLabel.AutoSize = true;
            this.FinalPriceTypeLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinalPriceTypeLabel.Location = new System.Drawing.Point(191, 44);
            this.FinalPriceTypeLabel.Name = "FinalPriceTypeLabel";
            this.FinalPriceTypeLabel.Size = new System.Drawing.Size(35, 14);
            this.FinalPriceTypeLabel.TabIndex = 6;
            this.FinalPriceTypeLabel.Text = "грн.";
            // 
            // FinalPriceLabel
            // 
            this.FinalPriceLabel.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinalPriceLabel.Location = new System.Drawing.Point(6, 21);
            this.FinalPriceLabel.Name = "FinalPriceLabel";
            this.FinalPriceLabel.Size = new System.Drawing.Size(183, 45);
            this.FinalPriceLabel.TabIndex = 0;
            this.FinalPriceLabel.Text = "0,00";
            this.FinalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FinalPriceLabel.TextChanged += new System.EventHandler(this.FinalPriceLabel_TextChanged);
            // 
            // GasQuantityTextBoxLabel
            // 
            this.GasQuantityTextBoxLabel.AutoSize = true;
            this.GasQuantityTextBoxLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GasQuantityTextBoxLabel.Location = new System.Drawing.Point(197, 135);
            this.GasQuantityTextBoxLabel.Name = "GasQuantityTextBoxLabel";
            this.GasQuantityTextBoxLabel.Size = new System.Drawing.Size(21, 14);
            this.GasQuantityTextBoxLabel.TabIndex = 7;
            this.GasQuantityTextBoxLabel.Text = "л.";
            // 
            // GasPriceTypeTextBoxLabel
            // 
            this.GasPriceTypeTextBoxLabel.AutoSize = true;
            this.GasPriceTypeTextBoxLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GasPriceTypeTextBoxLabel.Location = new System.Drawing.Point(197, 163);
            this.GasPriceTypeTextBoxLabel.Name = "GasPriceTypeTextBoxLabel";
            this.GasPriceTypeTextBoxLabel.Size = new System.Drawing.Size(35, 14);
            this.GasPriceTypeTextBoxLabel.TabIndex = 5;
            this.GasPriceTypeTextBoxLabel.Text = "грн.";
            // 
            // GasPriceTextBox
            // 
            this.GasPriceTextBox.Location = new System.Drawing.Point(124, 152);
            this.GasPriceTextBox.Name = "GasPriceTextBox";
            this.GasPriceTextBox.Size = new System.Drawing.Size(71, 25);
            this.GasPriceTextBox.TabIndex = 6;
            this.GasPriceTextBox.TextChanged += new System.EventHandler(this.GasPriceTextBox_TextChanged);
            // 
            // GasQuantityTextBox
            // 
            this.GasQuantityTextBox.Location = new System.Drawing.Point(124, 124);
            this.GasQuantityTextBox.Name = "GasQuantityTextBox";
            this.GasQuantityTextBox.Size = new System.Drawing.Size(71, 25);
            this.GasQuantityTextBox.TabIndex = 5;
            this.GasQuantityTextBox.TextChanged += new System.EventHandler(this.GasQuantityTextBox_TextChanged);
            // 
            // PriceCountTypeGroupBox
            // 
            this.PriceCountTypeGroupBox.Controls.Add(this.CountTypeByPriceRadioButton);
            this.PriceCountTypeGroupBox.Controls.Add(this.CountTypeByQuantityRadioButton);
            this.PriceCountTypeGroupBox.Location = new System.Drawing.Point(6, 113);
            this.PriceCountTypeGroupBox.Name = "PriceCountTypeGroupBox";
            this.PriceCountTypeGroupBox.Size = new System.Drawing.Size(114, 67);
            this.PriceCountTypeGroupBox.TabIndex = 4;
            this.PriceCountTypeGroupBox.TabStop = false;
            // 
            // CountTypeByPriceRadioButton
            // 
            this.CountTypeByPriceRadioButton.AutoSize = true;
            this.CountTypeByPriceRadioButton.Location = new System.Drawing.Point(6, 42);
            this.CountTypeByPriceRadioButton.Name = "CountTypeByPriceRadioButton";
            this.CountTypeByPriceRadioButton.Size = new System.Drawing.Size(66, 22);
            this.CountTypeByPriceRadioButton.TabIndex = 1;
            this.CountTypeByPriceRadioButton.TabStop = true;
            this.CountTypeByPriceRadioButton.Text = "Сумма";
            this.CountTypeByPriceRadioButton.UseVisualStyleBackColor = true;
            this.CountTypeByPriceRadioButton.CheckedChanged += new System.EventHandler(this.CountTypeByPriceRadioButton_CheckedChanged);
            // 
            // CountTypeByQuantityRadioButton
            // 
            this.CountTypeByQuantityRadioButton.AutoSize = true;
            this.CountTypeByQuantityRadioButton.Location = new System.Drawing.Point(6, 14);
            this.CountTypeByQuantityRadioButton.Name = "CountTypeByQuantityRadioButton";
            this.CountTypeByQuantityRadioButton.Size = new System.Drawing.Size(106, 22);
            this.CountTypeByQuantityRadioButton.TabIndex = 0;
            this.CountTypeByQuantityRadioButton.TabStop = true;
            this.CountTypeByQuantityRadioButton.Text = "Количество";
            this.CountTypeByQuantityRadioButton.UseVisualStyleBackColor = true;
            this.CountTypeByQuantityRadioButton.CheckedChanged += new System.EventHandler(this.CountTypeByQuantityRadioButton_CheckedChanged);
            // 
            // GasPricePanel
            // 
            this.GasPricePanel.Controls.Add(this.GasPriceTextBoxLabel);
            this.GasPricePanel.Controls.Add(this.GasPriceLabel);
            this.GasPricePanel.Controls.Add(this.GasPriceValueTextBox);
            this.GasPricePanel.Location = new System.Drawing.Point(6, 64);
            this.GasPricePanel.Name = "GasPricePanel";
            this.GasPricePanel.Size = new System.Drawing.Size(229, 34);
            this.GasPricePanel.TabIndex = 2;
            // 
            // GasPriceTextBoxLabel
            // 
            this.GasPriceTextBoxLabel.AutoSize = true;
            this.GasPriceTextBoxLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GasPriceTextBoxLabel.Location = new System.Drawing.Point(191, 15);
            this.GasPriceTextBoxLabel.Name = "GasPriceTextBoxLabel";
            this.GasPriceTextBoxLabel.Size = new System.Drawing.Size(35, 14);
            this.GasPriceTextBoxLabel.TabIndex = 4;
            this.GasPriceTextBoxLabel.Text = "грн.";
            // 
            // GasPriceLabel
            // 
            this.GasPriceLabel.AutoSize = true;
            this.GasPriceLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GasPriceLabel.Location = new System.Drawing.Point(3, 7);
            this.GasPriceLabel.Name = "GasPriceLabel";
            this.GasPriceLabel.Size = new System.Drawing.Size(40, 18);
            this.GasPriceLabel.TabIndex = 0;
            this.GasPriceLabel.Text = "Цена";
            // 
            // GasPriceValueTextBox
            // 
            this.GasPriceValueTextBox.Location = new System.Drawing.Point(68, 4);
            this.GasPriceValueTextBox.Name = "GasPriceValueTextBox";
            this.GasPriceValueTextBox.ReadOnly = true;
            this.GasPriceValueTextBox.Size = new System.Drawing.Size(121, 25);
            this.GasPriceValueTextBox.TabIndex = 3;
            // 
            // GasTypePanel
            // 
            this.GasTypePanel.Controls.Add(this.GasTypeComboBox);
            this.GasTypePanel.Controls.Add(this.GasTypeLabel);
            this.GasTypePanel.Location = new System.Drawing.Point(6, 24);
            this.GasTypePanel.Name = "GasTypePanel";
            this.GasTypePanel.Size = new System.Drawing.Size(192, 34);
            this.GasTypePanel.TabIndex = 1;
            // 
            // GasTypeComboBox
            // 
            this.GasTypeComboBox.FormattingEnabled = true;
            this.GasTypeComboBox.Location = new System.Drawing.Point(68, 4);
            this.GasTypeComboBox.Name = "GasTypeComboBox";
            this.GasTypeComboBox.Size = new System.Drawing.Size(121, 26);
            this.GasTypeComboBox.TabIndex = 1;
            this.GasTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.GasTypeComboBox_SelectedIndexChanged);
            // 
            // GasTypeLabel
            // 
            this.GasTypeLabel.AutoSize = true;
            this.GasTypeLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GasTypeLabel.Location = new System.Drawing.Point(3, 7);
            this.GasTypeLabel.Name = "GasTypeLabel";
            this.GasTypeLabel.Size = new System.Drawing.Size(56, 18);
            this.GasTypeLabel.TabIndex = 0;
            this.GasTypeLabel.Text = "Бензин";
            // 
            // GasStationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GasStationGroupBox);
            this.Name = "GasStationControl";
            this.Size = new System.Drawing.Size(250, 280);
            this.GasStationGroupBox.ResumeLayout(false);
            this.GasStationGroupBox.PerformLayout();
            this.FinalPriceGroupBox.ResumeLayout(false);
            this.FinalPriceGroupBox.PerformLayout();
            this.PriceCountTypeGroupBox.ResumeLayout(false);
            this.PriceCountTypeGroupBox.PerformLayout();
            this.GasPricePanel.ResumeLayout(false);
            this.GasPricePanel.PerformLayout();
            this.GasTypePanel.ResumeLayout(false);
            this.GasTypePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GasStationGroupBox;
        private System.Windows.Forms.Panel GasTypePanel;
        private System.Windows.Forms.ComboBox GasTypeComboBox;
        private System.Windows.Forms.Label GasTypeLabel;
        private System.Windows.Forms.Panel GasPricePanel;
        private System.Windows.Forms.Label GasPriceLabel;
        private System.Windows.Forms.TextBox GasPriceValueTextBox;
        private System.Windows.Forms.Label GasPriceTextBoxLabel;
        private System.Windows.Forms.RadioButton CountTypeByPriceRadioButton;
        private System.Windows.Forms.RadioButton CountTypeByQuantityRadioButton;
        private System.Windows.Forms.GroupBox PriceCountTypeGroupBox;
        private System.Windows.Forms.Label GasQuantityTextBoxLabel;
        private System.Windows.Forms.Label GasPriceTypeTextBoxLabel;
        private System.Windows.Forms.TextBox GasPriceTextBox;
        private System.Windows.Forms.TextBox GasQuantityTextBox;
        private System.Windows.Forms.GroupBox FinalPriceGroupBox;
        private System.Windows.Forms.Label FinalPriceLabel;
        private System.Windows.Forms.Label FinalPriceTypeLabel;
    }
}
