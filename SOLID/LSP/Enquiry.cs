using SOLID.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{

    // La clase Enquiry hereda de CustomerOcp, pero el metodo ADD no se implementa en la clase Enquiry
    // por tanto cuando instanciamos la clase padre y quiera acceder al metodo ADD, dara error por tanto
    // El principio de LSP, nos dice:
    // - El padre debería reemplazar fácilmente el objeto hijo y en este caso no puede, por tanto 
    // la clase Enquiry no formaria parte de Customer

    public class Enquiry : CustomerOcp
    {
        public override double getDiscount(double TotalSales) => base.getDiscount(TotalSales) - 5;

        public override void Add() => throw new Exception("Not allowed");

    }
}
