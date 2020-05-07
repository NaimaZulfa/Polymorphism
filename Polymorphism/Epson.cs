using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine ("Epson display dimension : 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}
