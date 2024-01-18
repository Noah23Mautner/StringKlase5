using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringklasa5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unos;

            Console.WriteLine("Unesite cijeli i decimalni broj:");
            unos = Console.ReadLine();

            string[] brojevi = unos.Split(' ');

            int x = int.Parse(brojevi[0]);
            double y = double.Parse(brojevi[1]);

            Console.WriteLine("Uneseni brojevi su:");
            Console.WriteLine("Cijeli broj: " + x);
            Console.WriteLine("Decimalni broj: " + y);

            Console.ReadLine();


        }
    }
}
