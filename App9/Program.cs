using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Acc<string> acc1 = new Acc<string>();
            acc1.Input();
            Console.WriteLine(acc1.GetInfo());

            Acc<string> acc2 = new Acc<string>();
            acc2.Input();
            Console.WriteLine(acc2.GetInfo());



            Console.ReadKey();
        }


        //Console.WriteLine("Введите числовой номер");
        //int kodInt = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите имя");
        //string name =Console.ReadLine(); 
        //Console.WriteLine("Введите цену");
        //int price = Convert.ToInt32(Console.ReadLine());

        //Tovar<int> tovar1 = new Tovar<int>(kodInt, name, price);

        //Console.WriteLine(tovar1.GetInfo());

        //Console.WriteLine("Введите строковый номер");
        //string kodString = Console.ReadLine();
        //Console.WriteLine("Введите имя");
        //name = Console.ReadLine();
        //Console.WriteLine("Введите цену");
        //price = Convert.ToInt32(Console.ReadLine());

        //Tovar<string> tovar2 = new Tovar<string>(kodString, name, price);
        //Console.WriteLine(tovar2.GetInfo());




        //static void Main(string[] args)
        //{

        //    //Console.WriteLine("Введите числовой номер");
        //    //int kodInt = Convert.ToInt32(Console.ReadLine());
        //    //Console.WriteLine("Введите имя");
        //    //string name =Console.ReadLine(); 
        //    //Console.WriteLine("Введите цену");
        //    //int price = Convert.ToInt32(Console.ReadLine());

        //    //Tovar<int> tovar1 = new Tovar<int>(kodInt, name, price);

        //    //Console.WriteLine(tovar1.GetInfo());

        //    //Console.WriteLine("Введите строковый номер");
        //    //string kodString = Console.ReadLine();
        //    //Console.WriteLine("Введите имя");
        //    //name = Console.ReadLine();
        //    //Console.WriteLine("Введите цену");
        //    //price = Convert.ToInt32(Console.ReadLine());

        //    //Tovar<string> tovar2 = new Tovar<string>(kodString, name, price);
        //    //Console.WriteLine(tovar2.GetInfo());

        //    Tovar<int> tovar1 = new Tovar<int>();
        //    tovar1.Input();
        //    Console.WriteLine(tovar1.GetInfo());

        //    Tovar<string> tovar2 = new Tovar<string>();
        //    tovar2.Input();
        //    Console.WriteLine(tovar2.GetInfo());



        //    Console.ReadKey();
        //}


    }
}
