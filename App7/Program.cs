using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArPr arpr = new ArPr();
            arpr.SetStart(10);
            arpr.setStep(2);
            Console.WriteLine(arpr.GetNext());
            Console.WriteLine(arpr.GetNext());
            Console.WriteLine(arpr.GetNext());
            arpr.Reset();
            Console.WriteLine(arpr.GetNext());
            Console.WriteLine(arpr.GetNext());
            GeoPr geopr = new GeoPr();
            geopr.SetStart(10);
            geopr.setStep(2);
            Console.WriteLine(geopr.GetNext());
            Console.WriteLine(geopr.GetNext());
            Console.WriteLine(geopr.GetNext());
            geopr.Reset();
            Console.WriteLine(geopr.GetNext());
            Console.WriteLine(geopr.GetNext());
            Console.ReadKey();
        }
    }
}
