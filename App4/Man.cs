using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Building
    {
        string adr;
        int dlin;
        int shir;
        int vys;

        
        string Adr
        {
            get 
            
            {
                return adr;
            }
            set
            {
                adr = value;
            }
        }
        int Dlin
        {
            get

            {
                return dlin;
            }
            set
            {
                dlin = value;
            }
        }
        int Shir
        {
            get

            {
                return shir;
            }
            set
            {
                shir = value;
            }
        }
        int Vys
        {
            get

            {
                return vys;
            }
            set
            {
                vys = value;
            }
        }

        public Building(string adr, int dlin, int shir, int vys)
        {
            this.Adr = adr;
            this.Dlin = dlin;
            this.Shir = shir;
            this.Vys = vys;
        }
        public string Print()
        {
            return $"{adr} {dlin} {shir} {vys}";
        }
    }

    //class Man
    //{
    //    string name;
    //    int birthdayDate;
    //    string city;

    //    int BirthdayDate
    //    {
    //        get

    //        {
    //            return birthdayDate
    //        }
    //        set
    //        {
    //            if (value > 2021)
    //                birthdayDate = 2021;
    //            else if (value < 1900)
    //                birthdayDate = 1900;
    //            else
    //                birthdayDate = value;
    //        }
    //    }

    //    public Man(string name, int birthdayDate, string city)
    //    {
    //        this.name = name;
    //        this.BirthdayDate = birthdayDate;
    //        this.city = city;
    //    }
    //    public string Print()
    //    {
    //        return $"{name} {birthdayDate} {city}";
    //    }
    //}

}
