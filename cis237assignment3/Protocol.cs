using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        int numLang;
        int price;

        public override void CalculateTotalCost()
        {
            price = numLang * 4;
            base.CalculateTotalCost();
            totalCost = totalCost + price;
        }
    }
}
