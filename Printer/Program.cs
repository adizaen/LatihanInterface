using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.name = "Epson";
            printer.name = "Canon";
            printer.name = "LaserJet";

            Console.WriteLine("Pilih printer :\n");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Laser Jet");

            Console.Write("Nomor Printer [1..3] : ");
            int pil = Convert.ToInt32(Console.ReadLine());

            IPrinterWindows printerwin;
            if (pil == 1)
                 printerwin = new Epson();
            else if (pil == 2)
                printerwin = new Canon();
            else
                printerwin = new LaserJet();

            printerwin.Show(printer);
            printerwin.Print(printer);

            Console.ReadKey();
        }
    }
}
