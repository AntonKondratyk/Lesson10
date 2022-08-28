using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    class Acc<T>
    {
        private T Kod { get; set; }
        private string Name { get; set; }
        private int Price { get; set; }


        public string GetInfo()
        {
            return $"{Kod} {Name} {Price}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Kod =(T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            Price = Convert.ToInt32(Console.ReadLine());
        }


        //public Tovar(T kod, string name, int price)
        //{
        //    Kod = kod;
        //    Name = name;
        //    Price = price;
        //}

        //class Tovar<T>
        //{
        //    public T Kod { get; set; }
        //    public string Name { get; set; }
        //    public int Price { get; set; }

        //    //public Tovar(T kod, string name, int price)
        //    //{
        //    //    Kod = kod;
        //    //    Name = name;
        //    //    Price = price;
        //    //}

        //    public string GetInfo()
        //    {
        //        return $"{Kod} {Name} {Price}";
        //    }

        //    public void Input()
        //    {
        //        Console.WriteLine("Введите номер");
        //        Kod = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        //        Console.WriteLine("Введите имя");
        //        Name = Console.ReadLine();
        //        Console.WriteLine("Введите цену");
        //        Price = Convert.ToInt32(Console.ReadLine());
        //    }



    }
    //class Employee
    //{
    //    public int Num { get; set; }
    //    public string Name { get; set; }
    //    public int Summa { get; set; }
    //}
}
