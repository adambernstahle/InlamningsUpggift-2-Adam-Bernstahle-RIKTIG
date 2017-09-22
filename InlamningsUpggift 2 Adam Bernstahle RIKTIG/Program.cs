using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exmpel1
{
    class Program
    {
        static void SkrivUtVeckodagar()
        {
            Console.WriteLine("AAAAA");
            Console.WriteLine("BBBBB");
            Console.WriteLine("CCCCC");
            Console.WriteLine("DDDDDD");
            Console.WriteLine("FredEEEEEEEag");
            Console.WriteLine("Lördag");
            Console.WriteLine("Söndag");
        }

        static void Main(string[] args)
        {
            SkrivUtVeckodagar();

            //Här görs något annat, t.ex inmatning eller beräkningar
            //för exemplet är det inte instressant. Poängen är att
            //vi vill upprepa samma utrskift som vi gjort tidigare 
            //en gång till vid ett senare tillfälle.

            SkrivUtVeckodagar();
        }
    }
}