using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{ 

    public class FileLogger
    {
        public void Handle(string error)
        {
            var pathError = "Error.txt";
            System.IO.File.WriteAllText(pathError, error);
        }
    }
}
