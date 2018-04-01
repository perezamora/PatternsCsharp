using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class EnquiryLsp : IDiscount
    {
        public double getDiscount(double TotalSales) => TotalSales - 5;
    }
}
