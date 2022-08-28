using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10_19_
{
    class Program
    {
        //public string Kod { get; set; }
        //public string Name { get; set; }
        //public int Fr { get; set; }
        //public int VolDDR { get; set; }
        //public int VolHdd { get; set; }
        //public int VolGC { get; set; }
        //public int Price { get; set; }

        //public int Q { get; set; }

        static void Main(string[] args)
        {
            List<Tovar> tovars = new List<Tovar>()
            {
            new Tovar(){Kod= "1 Комп", Name="Байкал", Fr=1, VolDDR=1, VolHdd=1, VolGC=1, Price=7, Q=1},
            new Tovar(){Kod= "2 Комп", Name="Интел",  Fr=2, VolDDR=2, VolHdd=2, VolGC=2, Price=2, Q=2},
            new Tovar(){Kod= "3 Комп", Name="Интел",  Fr=3, VolDDR=3, VolHdd=3, VolGC=3, Price=3, Q=3},
            new Tovar(){Kod= "4 Комп", Name="Интел",  Fr=4, VolDDR=4, VolHdd=4, VolGC=4, Price=4, Q=4},
            new Tovar(){Kod= "5 Комп", Name="Байкал",  Fr=5, VolDDR=5, VolHdd=5, VolGC=5, Price=5, Q=5},
            new Tovar(){Kod= "6 Комп", Name="Байкал",  Fr=6, VolDDR=6, VolHdd=6, VolGC=6, Price=6, Q=31},
            };

            Console.WriteLine("Введите проц");
            string Name = Console.ReadLine();
            List<Tovar> tovars1 = tovars.Where(x => x.Name == Name).ToList();
            Print(tovars1);

            Console.WriteLine("Введите v ОЗУ");
            int volddr = Convert.ToInt32(Console.ReadLine());
            List<Tovar> tovars2 = tovars.Where(x => x.VolDDR >= volddr).ToList();
            Print(tovars2);


            IEnumerable<IGrouping<string, Tovar>> tovar4 = tovars.GroupBy(x => x.Name);
            foreach (IGrouping<string, Tovar> gr in tovar4)
            {
                Console.WriteLine(gr.Key);
                foreach (Tovar t in gr)
                {
                    Console.WriteLine($"{t.Kod} {t.Name} {t.Price} {t.Q}");
                }
            }

            Tovar tovar5 = tovars.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{tovar5.Kod} {tovar5.Name} {tovar5.Price} {tovar5.Q}");

            Tovar tovar6 = tovars.OrderByDescending(x => x.Price).LastOrDefault();
            Console.WriteLine($"{tovar6.Kod} {tovar6.Name} {tovar6.Price} {tovar6.Q}");

            Console.WriteLine(tovars.Any(x => x.Q >= 30));

            //List<Tovar> tovars3 = tovars.OrderBy(x => x.Price).ToList();
            //Print(tovars3);

            //IEnumerable<IGrouping<string, Tovar>> tovar4 = tovars.GroupBy(x => x.City);
            //foreach (IGrouping<string, Tovar> gr in tovar4)
            //{
            //    Console.WriteLine(gr.Key);
            //    foreach (Tovar t in gr)
            //    {
            //        Console.WriteLine($"{t.Kod} {t.Name} {t.Price} {t.City}");
            //    }
            //}

            Console.ReadKey();
        }

        static void Print(List<Tovar> tovars)
        {
            foreach (Tovar t in tovars)
            {
                Console.WriteLine($"{t.Kod} {t.Name} {t.Price} {t.Q}");
            }
            Console.WriteLine();
        }
    }
}