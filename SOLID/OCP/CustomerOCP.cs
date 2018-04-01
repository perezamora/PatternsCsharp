using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOLID.OCP
{
    // La clase "Cliente" ahora está cerrada por cualquier modificación nueva
    // Pero está abierta para extensiones cuando se agregan nuevos tipos de clientes al proyecto.

    public class CustomerOcp
    {
        public virtual void Add()
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

        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }
}
