using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOLID.SRP
{
    public class Customer
    {

        // En este metodo esta realizando acciones que no deberian de hacer
        // registrar los errores que se podrucen, mas responsabilidad de la 
        // deberia hacer (SRP (Single responsibility principle)).
        // SRP -> Una clase solo deberia de tener una responsabilidad y no multiple.

        public void Add()
        {
            try
            {
                // Tratamiento metodo Add (fichero, bbdd)
                Console.WriteLine("Add metodo Customer");
            }
            catch (Exception ex)
            {
                File.WriteAllText("Error.txt", ex.ToString());
            }
        }
    }
}
