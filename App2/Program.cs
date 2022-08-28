using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
           // double c = Convert.ToDouble(Console.ReadLine());

            Quadratic quadratic = new Quadratic(k, b);
            Console.WriteLine(quadratic.Root());
            Console.ReadKey();
        }
    }
}
