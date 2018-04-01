using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class Customer
    {
        // El principal problema que encontramos en esta implementacion, es que si 
        // queremos añadir un nuveo tipo de descuento, deberemos de modificar la clase
        // Con lo que comporta que debemos probar la clase una y otra vez, pudiendo 
        // introducir errores que antes funcionaban.

        // El principio OCP, nos sugiere que en vez de modificar la clase la extendamos.
        // Crear una clase extendiendo de la anterior, asegurandonos que el codigo 
        // sigue funcionando.

        private int _CustType;

        public int CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }

        public double getDiscount(double TotalSales)
        {
            if (_CustType == 1)
            {
                return TotalSales - 100;
            }
            else
            {
                return TotalSales - 50;
            }
        }
    }
}
