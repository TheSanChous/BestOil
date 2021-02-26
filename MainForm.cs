using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class MainForm : Form
    {
        decimal AllSum = 0.00m;

        decimal GasPrice = 0.00m;
        decimal CafePrice = 0.00m;

        public MainForm()
        {
            InitializeComponent();
            GasStationControl.FinalPriceChanged += GasStationControl_FinalPriceChanged;
            MiniCafeControl.FinalPriceChanged += MiniCafeControl_FinalPriceChanged;
            FinalPriceControl.ConfirmButtonClick += FinalPriceControl_ConfirmButtonClick;
        }

        private void FinalPriceControl_ConfirmButtonClick()
        {
            AllSum += CafePrice + GasPrice;
            GasStationControl.Reset();
            MiniCafeControl.Reset();
            CafePrice = 0.00m;
            GasPrice = 0.00m;
        }

        private void MiniCafeControl_FinalPriceChanged(decimal obj)
        {
            CafePrice = obj;
            ChangeFinalPrice();
        }

        private void GasStationControl_FinalPriceChanged(decimal obj)
        {
            GasPrice = obj;
            ChangeFinalPrice();
        }

        public void ChangeFinalPrice()
        {
            FinalPriceControl.SetFinalPrice(GasPrice + CafePrice);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(this, $"Общая прибыль: {AllSum}", "До свидания!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
