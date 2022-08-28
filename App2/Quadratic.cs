using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    struct Quadratic
    {
        double k;
        double b;
        //double c;

        public Quadratic (double k, double b)
        {
            this.k = k;
            this.b = b;
          //  this.c = c;
        }

        public string Root()
        {
            double x = -b/k;
            
            return $"реш - {x}";

        }
        //struct Quadratic
        //{
        //    double a;
        //    double b;
        //    double c;

        //    public Quadratic(double a, double b, double c)
        //    {
        //        this.a = a;
        //        this.b = b;
        //        this.c = c;
        //    }

        //    public string Root()
        //    {
        //        double d2 = b * b - 4 * a * c;
        //        if (d2 < 0)
        //            return "Решений нет";
        //        double r1 = (-b + Math.Sqrt(d2)) / (2 * a);
        //        double r2 = (-b + Math.Sqrt(d2)) / (2 * a);
        //        return $"Пер реш - {r1}\nВтор реш - {r2}";

        //    }
        }
}
