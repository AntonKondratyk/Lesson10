using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int grad_ = Convert.ToInt32(Console.ReadLine());
            int min_ = Convert.ToInt32(Console.ReadLine());
            int sec_ = Convert.ToInt32(Console.ReadLine());

            Angle angle = new Angle(grad_, min_, sec_);
            //
            //https://planetcalc.ru/71/#:~:text=%D0%9F%D0%B5%D1%80%D0%B5%D0%B2%D0%BE%D0%B4%D0%B8%D1%82%20%D0%B5%D0%B4%D0%B8%D0%BD%D0%B8%D1%86%D1%8B%20%D0%B8%D0%B7%D0%BC%D0%B5%D1%80%D0%B5%D0%BD%D0%B8%D1%8F%20%D1%83%D0%B3%D0%BB%D0%BE%D0%B2%20%D0%B8%D0%B7,%D1%81%D0%B5%D0%BA%D1%83%D0%BD%D0%B4%D1%8B%2F60)%2F60%C2%BB.
            //
            double totalSecond = angle.ToRadians();
            Console.WriteLine("{0:f4}",totalSecond);
            Console.ReadKey();
            //int hour_ = Convert.ToInt32(Console.ReadLine());
            //int minute_ = Convert.ToInt32(Console.ReadLine());
            //int second_ = Convert.ToInt32(Console.ReadLine());

            //Clock clock = new Clock(hour_, minute_, second_);

            ////Clock clock = new Clock() {hour=hour_, minute=minute_,second=second_};
            ////clock.hour = Convert.ToInt32(Console.ReadLine());
            ////clock.minute = Convert.ToInt32(Console.ReadLine());
            ////clock.second = Convert.ToInt32(Console.ReadLine());


            //int totalSecond = clock.ToSecond();
            //Console.WriteLine(totalSecond);
            //Console.ReadKey();
        }
    }
}
