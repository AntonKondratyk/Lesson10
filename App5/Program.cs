using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка", "Мяу");
            Console.WriteLine(cat.ShowInfo());
            //MultiBuilding multiBuilding = new MultiBuilding("гор улиц", 1, 2, 3, 4);
            //Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
