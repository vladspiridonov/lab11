using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("k:");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b:");
            double b = Convert.ToDouble(Console.ReadLine());
            LinEquation linEquation = new LinEquation(k,b);
            Console.WriteLine(linEquation.Root());
            Console.ReadKey();
        }
    }
}
