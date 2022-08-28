using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    sealed class MultiBuilding: Building
    {
        int etag;

        int Etag
        {
            get

            {
                return etag;
            }
            set
            {
                etag = value;
            }
        }
        public MultiBuilding (string adr, int dlin, int shir, int vys, int etag)
            :base (adr, dlin, shir, vys)
        {
            this.Etag = etag;
        }

        public string Print()
        {
            string result = base.Print();
            result += $" {etag}";
            return result;
        }
    }

    //class Student : Building
    //{
    //    string university;
    //    public Student(string adr, int birthdayDate, string city, string university)
    //        : base(name, birthdayDate, city)
    //    {
    //        this.university = university;
    //    }

    //    public string Print()
    //    {
    //        string result = base.Print();
    //        result += $" {university}";
    //        return result;
    //    }
    //}
}
