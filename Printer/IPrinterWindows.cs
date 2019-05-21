using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    interface IPrinterWindows
    {
        void Show(Printer printer);
        void Print(Printer printer);
    }
}
