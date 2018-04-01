using SOLID.LSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Comprobacion del principio LSP (Liskov sustitution principle).
            List<IDatabase> Customers = new List<IDatabase>();
            Customers.Add(new GoldCustomerLsp());
            //Customers.Add(new EnquiryLsp()); 
            // nos da error ya que la classe EnquiryLsp no hereda interfaz IDatabase y no tiene implementado el metodo Add

            foreach (IDatabase o in Customers)
            {
                o.Add();
            }

        }
    }
}
