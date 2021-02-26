using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil.Controls
{
    public partial class FinalPriceControl : UserControl
    {
        public event Action ConfirmButtonClick;

        public FinalPriceControl()
        {
            InitializeComponent();
        }

        public void SetFinalPrice(decimal price)
        {
            FinalPriceLabel.Text = price.ToString();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ConfirmButtonClick();
        }
    }
}
