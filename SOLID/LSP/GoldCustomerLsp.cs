using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class GoldCustomerLsp : CustomerLsp
    {
        public override double getDiscount(double TotalSales) => base.getDiscount(TotalSales) - 100;
    }
}
