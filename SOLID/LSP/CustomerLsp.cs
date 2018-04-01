using SOLID.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{

    // Customer hereda de las dos interfaces.

    public class CustomerLsp : IDiscount, IDatabase
    {
        private FileLogger obj = new FileLogger();

        public virtual void Add()
        {
            try
            {
                Console.WriteLine("Acces to database ");
            }
            catch (Exception ex)
            {
                obj.Handle(ex.Message.ToString());
            }
        }

        public virtual double getDiscount(double TotalSales) => TotalSales;
    }
}
