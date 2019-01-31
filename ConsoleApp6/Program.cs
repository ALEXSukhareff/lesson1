using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte name1 = 251;
            sbyte name2 = -122;
            short name3 = -11999;
            ushort name4 = 60444;
            int name5 = 23999435;
            uint name6 = 877;
            long name7 = 1005;
            ulong name8 = 30777;
            float name9 = 16.867f;
            double name10 = 355.1122993;
            decimal name11 = 8.9198844m;
            char a = jjj;

            short name12 = name1;
            Console.WriteLine(name12);
            int name13 = name1;
            Console.WriteLine(name13);
            long name14 = name1;
            Console.WriteLine(name14);
            int name15 = (int)name3;
            Console.WriteLine(name15);
            int name16 = (int)name7;
            Console.WriteLine(name16);
            long name17 = name6;
            Console.WriteLine(name17);
            float name18 = (float)name10;
            Console.WriteLine(name18);
            double name19 = name9;
            Console.WriteLine(name19);
            int name20 = a;
            Console.WriteLine(name20);

            Console.ReadKey();
        }
    }
}
