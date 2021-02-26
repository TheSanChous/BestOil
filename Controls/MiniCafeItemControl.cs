using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BestOil.Controls
{
    public partial class MiniCafeItemControl : UserControl
    {
        int Count
        {
            get
            {
                return (int)CountNumericUpDown.Value;
            }
        }

        public decimal ItemPrice { get; }

        public decimal FinalPrice => CheckBox.Checked ? Count * ItemPrice : 0;

        public event EventHandler ItemChanged;

        public MiniCafeItemControl(string itemName, decimal itemPrice)
        {
            InitializeComponent();
            CheckBox.Text = itemName;
            PriceTextBox.Text = itemPrice.ToString();
            ItemPrice = itemPrice;
        }

        private void ItemCheckedOrChanged(object sender, EventArgs e)
        {
            ItemChanged(this, null);
        }
    }

    class MiniCafeItemInfo
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public MiniCafeItemInfo(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<MiniCafeItemInfo> GetMiniCafeItemInfos()
        {
            return new List<MiniCafeItemInfo>
            {
                new MiniCafeItemInfo("Хот-дог", 15.00m),
                new MiniCafeItemInfo("Гамбургер", 19.50m),
                new MiniCafeItemInfo("Картошка-фри",25.00m),
                new MiniCafeItemInfo("Кока-кола", 12.75m)
            };
        }
    }
}
