using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building ("ул. гор", 1,2,3);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("гор улиц", 1,2,3,4);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
            //Man man = new Man("Иванов", 2000, "Москва");
            //Console.WriteLine(man.Print());
            //Student student = new Student("Петров", 1990, "СПб", "ИТМО");
            //Console.WriteLine(student.Print());
            //Console.ReadKey();
        }
    }
}
