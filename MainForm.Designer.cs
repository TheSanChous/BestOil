namespace BestOil
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
            this.FinalPriceControl = new BestOil.Controls.FinalPriceControl();
            this.MiniCafeControl = new BestOil.Controls.MiniCafeControl();
            this.GasStationControl = new BestOil.Controls.GasStationControl();
            this.SuspendLayout();
            // 
            // FinalPriceControl
            // 
            this.FinalPriceControl.Location = new System.Drawing.Point(11, 291);
            this.FinalPriceControl.Name = "FinalPriceControl";
            this.FinalPriceControl.Size = new System.Drawing.Size(546, 86);
            this.FinalPriceControl.TabIndex = 2;
            // 
            // MiniCafeControl
            // 
            this.MiniCafeControl.Location = new System.Drawing.Point(269, 12);
            this.MiniCafeControl.Name = "MiniCafeControl";
            this.MiniCafeControl.Size = new System.Drawing.Size(289, 289);
            this.MiniCafeControl.TabIndex = 1;
            // 
            // GasStationControl
            // 
            this.GasStationControl.Location = new System.Drawing.Point(12, 12);
            this.GasStationControl.Name = "GasStationControl";
            this.GasStationControl.Size = new System.Drawing.Size(251, 289);
            this.GasStationControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 394);
            this.Controls.Add(this.FinalPriceControl);
            this.Controls.Add(this.MiniCafeControl);
            this.Controls.Add(this.GasStationControl);
            this.MaximumSize = new System.Drawing.Size(585, 433);
            this.MinimumSize = new System.Drawing.Size(585, 433);
            this.Name = "MainForm";
            this.Text = "Best Oil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GasStationControl GasStationControl;
        private Controls.MiniCafeControl MiniCafeControl;
        private Controls.FinalPriceControl FinalPriceControl;
    }
}

