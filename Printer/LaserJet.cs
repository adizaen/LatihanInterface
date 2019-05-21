using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class LaserJet : IPrinterWindows
    {
        public void Print(Printer printer)
        {
            Console.WriteLine("LaserJet printer printing ....");
        }

        public void Show(Printer printer)
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }
    }
}
