using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOLID.SRP
{
    public class CustomerSRP
    {
        // Ahora la clase de Customer puede delegar la actividad de registro en la clase "FileLogger" y 
        // puede concentrarse en las actividades relacionadas con el Customer.
        private FileLogger obj = new FileLogger();

        public void Add()
        {
            try
            {
                Console.WriteLine("Add metodo Customer");
            }
            catch (Exception ex)
            {
                obj.Handle(ex.ToString());
            }
        }
    }
}
