namespace BestOil.Controls
{
    partial class MiniCafeControl
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
            this.MiniCafeGroupBox = new System.Windows.Forms.GroupBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.FinalPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.FinalPriceTypeLabel = new System.Windows.Forms.Label();
            this.FinalPriceLabel = new System.Windows.Forms.Label();
            this.ItemsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MiniCafeGroupBox.SuspendLayout();
            this.FinalPriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MiniCafeGroupBox
            // 
            this.MiniCafeGroupBox.Controls.Add(this.CountLabel);
            this.MiniCafeGroupBox.Controls.Add(this.Pricelabel);
            this.MiniCafeGroupBox.Controls.Add(this.FinalPriceGroupBox);
            this.MiniCafeGroupBox.Controls.Add(this.ItemsFlowLayoutPanel);
            this.MiniCafeGroupBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiniCafeGroupBox.Location = new System.Drawing.Point(4, 4);
            this.MiniCafeGroupBox.Name = "MiniCafeGroupBox";
            this.MiniCafeGroupBox.Size = new System.Drawing.Size(279, 273);
            this.MiniCafeGroupBox.TabIndex = 0;
            this.MiniCafeGroupBox.TabStop = false;
            this.MiniCafeGroupBox.Text = "Мини-кафе";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(186, 15);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(88, 18);
            this.CountLabel.TabIndex = 8;
            this.CountLabel.Text = "Количество";
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Location = new System.Drawing.Point(131, 15);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(40, 18);
            this.Pricelabel.TabIndex = 7;
            this.Pricelabel.Text = "Цена";
            // 
            // FinalPriceGroupBox
            // 
            this.FinalPriceGroupBox.Controls.Add(this.FinalPriceTypeLabel);
            this.FinalPriceGroupBox.Controls.Add(this.FinalPriceLabel);
            this.FinalPriceGroupBox.Location = new System.Drawing.Point(6, 195);
            this.FinalPriceGroupBox.Name = "FinalPriceGroupBox";
            this.FinalPriceGroupBox.Size = new System.Drawing.Size(268, 71);
            this.FinalPriceGroupBox.TabIndex = 6;
            this.FinalPriceGroupBox.TabStop = false;
            this.FinalPriceGroupBox.Text = "К оплате:";
            // 
            // FinalPriceTypeLabel
            // 
            this.FinalPriceTypeLabel.AutoSize = true;
            this.FinalPriceTypeLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinalPriceTypeLabel.Location = new System.Drawing.Point(227, 44);
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
            this.FinalPriceLabel.Size = new System.Drawing.Size(221, 45);
            this.FinalPriceLabel.TabIndex = 0;
            this.FinalPriceLabel.Text = "0,00";
            this.FinalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FinalPriceLabel.TextChanged += new System.EventHandler(this.FinalPriceLabel_TextChanged);
            // 
            // ItemsFlowLayoutPanel
            // 
            this.ItemsFlowLayoutPanel.AutoScroll = true;
            this.ItemsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ItemsFlowLayoutPanel.Location = new System.Drawing.Point(6, 36);
            this.ItemsFlowLayoutPanel.Name = "ItemsFlowLayoutPanel";
            this.ItemsFlowLayoutPanel.Size = new System.Drawing.Size(268, 153);
            this.ItemsFlowLayoutPanel.TabIndex = 0;
            // 
            // MiniCafeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MiniCafeGroupBox);
            this.Name = "MiniCafeControl";
            this.Size = new System.Drawing.Size(290, 280);
            this.MiniCafeGroupBox.ResumeLayout(false);
            this.MiniCafeGroupBox.PerformLayout();
            this.FinalPriceGroupBox.ResumeLayout(false);
            this.FinalPriceGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MiniCafeGroupBox;
        private System.Windows.Forms.FlowLayoutPanel ItemsFlowLayoutPanel;
        private System.Windows.Forms.GroupBox FinalPriceGroupBox;
        private System.Windows.Forms.Label FinalPriceTypeLabel;
        private System.Windows.Forms.Label FinalPriceLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label Pricelabel;
    }
}
