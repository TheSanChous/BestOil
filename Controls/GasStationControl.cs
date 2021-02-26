using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BestOil.Controls
{
    public partial class GasStationControl : UserControl
    {
        enum CountBy
        {
            Quantity, Price
        }

        private CountBy countBy;
        private GasTypeInfo currentGasTypeInfo;

        public decimal FinalPrice { get; private set; }

        public event Action<decimal> FinalPriceChanged;

        public GasStationControl()
        {
            InitializeComponent();
            SetGasTypeInfos(GasTypeInfo.GetGasTypeInfos());
        }

        private void CountTypeByQuantityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetPriceCountingBy(CountBy.Quantity);
        }

        private void CountTypeByPriceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetPriceCountingBy(CountBy.Price);
        }

        private void GasQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            RecalculateFinalPrice();
        }

        private void GasPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            RecalculateFinalPrice();
        }

        private void FinalPriceLabel_TextChanged(object sender, EventArgs e)
        {
            FinalPriceChanged(FinalPrice);
        }

        private void SetGasTypeInfos(IEnumerable<GasTypeInfo> gasTypeInfos)
        {
            GasTypeComboBox.Items.Clear();
            GasTypeComboBox.Items.AddRange(gasTypeInfos.ToArray());
        }

        private void GasTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GasTypeComboBox.SelectedItem is GasTypeInfo gasTypeInfo)
            {
                GasPriceValueTextBox.Text = gasTypeInfo.Price.ToString();
                currentGasTypeInfo = gasTypeInfo;
                RecalculateFinalPrice();
            }
        }

        private void SetPriceCountingBy(CountBy newCountBy)
        {
            switch (newCountBy)
            {
                case CountBy.Quantity:
                    countBy = CountBy.Quantity;
                    GasQuantityTextBox.Enabled = true;
                    GasPriceTextBox.Enabled = false;
                    RecalculateFinalPrice();
                    break;
                case CountBy.Price:
                    countBy = CountBy.Price;
                    GasQuantityTextBox.Enabled = false;
                    GasPriceTextBox.Enabled = true;
                    RecalculateFinalPrice();
                    break;
            }
        }

        private void RecalculateFinalPrice()
        {
            if (currentGasTypeInfo != null)
            {
                decimal price = 0.00m;
                decimal liters;

                if (countBy == CountBy.Quantity && decimal.TryParse(GasQuantityTextBox.Text, out liters))
                {
                    price = Math.Round(currentGasTypeInfo.Price * liters, 2);
                    GasPriceTextBox.Text = price.ToString();
                }
                else if (countBy == CountBy.Price && decimal.TryParse(GasPriceTextBox.Text, out price))
                {
                    GasQuantityTextBox.Text = Math.Round((price / currentGasTypeInfo.Price), 2).ToString();
                }
                FinalPrice = price;
                FinalPriceLabel.Text = FinalPrice.ToString();
            }
            else
            {
                GasPriceTextBox.Text = null;
                GasQuantityTextBox.Text = null;
                GasTypeComboBox.SelectedItem = null;
                GasPriceValueTextBox.Text = null;
                FinalPrice = 0.00m;
                FinalPriceLabel.Text = FinalPrice.ToString();
            }
        }

        public void Reset()
        {
            currentGasTypeInfo = null;
            RecalculateFinalPrice();
        }
    }
}
