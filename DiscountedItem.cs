using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci_3_5
{
    class DiscountedItem:RentableDecorator
    {
        private readonly double discount = 23;
        public DiscountedItem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() * discount/100;
        }
        public override String Description
        {
            get
            {
                return "Trending: " + base.Description + ". Now at" + this.discount + "% off!";
            }
        }
    }
}
