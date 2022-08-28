using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }

    class Cat: Animal
    {
        string name;
        string say;
        //string country;
        //string taste;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Cat(string name, string say)
            :base(name) 
        {
            this.say = say;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");        
        }
    }

    class Dog : Animal
    {
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name)
            : base(name)

        {
           
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
    //abstract class Fruit
    //{
    //    public abstract string Name { get; set; }

    //    public Fruit(string name)
    //    {
    //        Name = name;
    //    }
    //    public abstract void GetTaste();

    //    public void ShowInfo()
    //    {
    //        Console.WriteLine(Name);
    //        GetTaste();
    //    }
    //}

    //class Apple : Fruit
    //{
    //    string country;
    //    string taste;
    //    string name;
    //    public override string Name
    //    {
    //        get => name;
    //        set => name = value;
    //    }

    //    public Apple(string name, string taste, string country)
    //        : base(name)

    //    {
    //        this.taste = taste;
    //        this.country = country;

    //    }
    //    public override void GetTaste()
    //    {
    //        Console.WriteLine(taste);
    //    }
    //}

    //class Lemon : Fruit
    //{
    //    int level;
    //    private string name
    //    public override string Name
    //    {
    //        get => name;
    //        set => name = value;
    //    }

    //    public Lemon(string name, int level)
    //        : base(name)

    //    {
    //        this.level = level;
    //    }
    //    public override void GetTaste()
    //    {
    //        Console.WriteLine("Кислый");
    //    }
    //}
}
