using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    static class Circule
    {
        static public double GetLenght(double r)
        {
            return 2*r*Math.PI;
        }
        static public double GetSquare(double r)
        {
            return  r*r*Math.PI;
        }
        static public string GetInCircule(double x, double y, double r)
        {
            double l = Math.Sqrt(x * x + y * y);
            if (l>r)
                return "Не в окружности";
            return "В окружности";
        }
    }
    //static class Rectangle
    //{
    //    static public double GetSquare(double a, double b)
    //    {
    //        return a * b;
    //    }
    //    static public double GetPerimetr(double a, double b)
    //    {
    //        return 2 * (a + b);
    //    }
    //}
}
