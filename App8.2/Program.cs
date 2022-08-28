using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace App8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Tovar[] tovars = JsonSerializer.Deserialize<Tovar[]>(jsonString);

            Tovar maxPrice = tovars[0];
            foreach (Tovar e in tovars)
            {
                if (e.Price > maxPrice.Price)
                {
                    maxPrice = e;
                }
            }

            Console.WriteLine($"{maxPrice.Name}");
            Console.ReadKey();
        }

        //static void Main(string[] args)
        //{
        //    string jsonString = String.Empty;
        //    using (StreamReader sr = new StreamReader("../../../Employees.json"))
        //    {
        //        jsonString = sr.ReadToEnd();
        //    }
        //    Employee[] employees = JsonSerializer.Deserialize<Employee[]>(jsonString);

        //    Employee maxEmployee = employees[0];
        //    foreach (Employee e in employees)
        //    {
        //        if (e.Summa > maxEmployee.Summa)
        //        {
        //            maxEmployee = e;
        //        }
        //    }

        //    Console.WriteLine($"{maxEmployee.Name} {maxEmployee.Num} {maxEmployee.Summa}");
        //    Console.ReadKey();
        //}


    }
}
