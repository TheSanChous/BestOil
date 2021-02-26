namespace BestOil.Controls
{
    partial class MiniCafeItemControl
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
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.CountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBox
            // 
            this.CheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBox.Location = new System.Drawing.Point(0, 0);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(87, 28);
            this.CheckBox.TabIndex = 0;
            this.CheckBox.Text = "Хот-дог";
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.CheckedChanged += new System.EventHandler(this.ItemCheckedOrChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTextBox.Location = new System.Drawing.Point(93, 3);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(41, 22);
            this.PriceTextBox.TabIndex = 1;
            // 
            // CountNumericUpDown
            // 
            this.CountNumericUpDown.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountNumericUpDown.Location = new System.Drawing.Point(140, 3);
            this.CountNumericUpDown.Name = "CountNumericUpDown";
            this.CountNumericUpDown.Size = new System.Drawing.Size(44, 22);
            this.CountNumericUpDown.TabIndex = 2;
            this.CountNumericUpDown.ValueChanged += new System.EventHandler(this.ItemCheckedOrChanged);
            // 
            // MiniCafeItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.CountNumericUpDown);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.CheckBox);
            this.Name = "MiniCafeItemControl";
            this.Size = new System.Drawing.Size(187, 28);
            ((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.NumericUpDown CountNumericUpDown;
    }
}
