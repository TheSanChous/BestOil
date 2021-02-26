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
    public partial class MiniCafeControl : UserControl
    {
        public decimal FinalPrice { get; private set; }

        public event Action<decimal> FinalPriceChanged;

        public MiniCafeControl()
        {
            InitializeComponent();
            InitializeCafeItems(MiniCafeItemInfo.GetMiniCafeItemInfos());
        }

        private void InitializeCafeItems(IEnumerable<MiniCafeItemInfo> miniCafeItemInfos)
        {
            var miniCafeItems = miniCafeItemInfos
                .Select(i => new MiniCafeItemControl(i.Name, i.Price))
                .ToList();                

            miniCafeItems.ForEach(i => i.ItemChanged += I_ItemChanged);

            ItemsFlowLayoutPanel.Controls.Clear();
            ItemsFlowLayoutPanel.Controls.AddRange(miniCafeItems.ToArray());
        }

        private void I_ItemChanged(object sender, EventArgs e)
        {
            FinalPrice = 0.00m;

            foreach (var item in ItemsFlowLayoutPanel.Controls)
            {
                if(item is MiniCafeItemControl miniCafeItem)
                {
                    FinalPrice += miniCafeItem.FinalPrice;
                }
            }

            FinalPriceLabel.Text = Math.Round(FinalPrice, 2).ToString();
        }

        private void FinalPriceLabel_TextChanged(object sender, EventArgs e)
        {
            FinalPriceChanged(FinalPrice);
        }

        public void Reset()
        {
            InitializeCafeItems(MiniCafeItemInfo.GetMiniCafeItemInfos());
            I_ItemChanged(null, null);
        }
    }
}
