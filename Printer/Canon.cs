using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Canon : IPrinterWindows
    {
        public void Print(Printer printer)
        {
            Console.WriteLine("Canon printer printing ....");
        }

        public void Show(Printer printer)
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
    }
}
