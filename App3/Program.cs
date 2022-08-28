using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double lenght = Circule.GetLenght(r);
            double square = Circule.GetSquare(r);
            string incircule = Circule.GetInCircule(x,y,r);
            Console.WriteLine($"{lenght} \n{square} \t {incircule}");
            Console.ReadKey();
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double square = Rectangle.GetSquare(a, b);
            //double perimetr = Rectangle.GetPerimetr(a, b);
            //Console.WriteLine($"{square} \n{perimetr}");
            //Console.ReadKey();
        }
    }
}
