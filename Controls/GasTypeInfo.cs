using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil.Controls
{
    class GasTypeInfo
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public GasTypeInfo(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name;
        }

        public static List<GasTypeInfo> GetGasTypeInfos()
        {
            return new List<GasTypeInfo>
            {
                new GasTypeInfo("A-95", 28.30m),
                new GasTypeInfo("A-92", 23.71m),
                new GasTypeInfo("Diesel", 24.07m)
            };
        }
    }
}
