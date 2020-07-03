using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;

            Console.WriteLine($"a = {a}");

            sbyte b = (sbyte)a;
            Console.WriteLine($"b = {b}");

            byte c = 0xF0;
            Console.WriteLine($"c = {c}");

            uint d = 0xcd;
            Console.WriteLine($"d = {d}");
        }
    }
}
