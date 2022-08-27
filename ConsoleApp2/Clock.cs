using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Angle
    {
        double grad; // это поля. наполнили данными
        double min;
        double sec;

        public double Grad
        {
            get
            {
                return grad;
            }
            set
            {
                if (value < 0 & value > 60)
                { Console.WriteLine("0-60!!!"); }
                else
                { grad = value; }
            }
        }
        public double Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value > 0 & value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("0-60!!!");
                }
            }
        }
        public double Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value > 0 & value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("0-60!!!");
                }
            }
        }
        public Angle(double grad, double min, double sec)
        {
            this.grad = grad;
            this.min = min;
            this.sec = sec;
        }

        public double ToRadians() // переменные прописывать не надо, метод имеет к ним доступ внутри класса
        {
            return (grad + (min + sec / 60) / 60) * Math.PI / 180;
        }
    }
    //class Clock
    //{
    //    int hour; // это поля. наполнили данными
    //    int minute;
    //    int second;

    //    public int Hour
    //    {
    //        get
    //        {
    //            return hour;
    //        }
    //        set
    //        {
    //            hour = value % 24;
    //        }
    //    }
    //    public int Minute
    //    {
    //        get
    //        {
    //            return minute;
    //        }
    //        set
    //        {
    //            Hour += value / 60;
    //            minute = value % 60;
    //         }
    //    }
    //    public int Second
    //    {
    //        get
    //        {
    //            return second;
    //        }
    //        set
    //        {
    //            Minute += value /60;
    //            second = value % 60;
    //        }
    //    }
    //    public Clock(int hour, int minute, int second)
    //    {
    //        this.hour = hour;
    //        this.minute = minute;
    //        this.second = second;
    //    }

    //    public int ToSecond() // переменные прописывать не надо, метод имеет к ним доступ внутри класса
    //    {
    //        return second + minute * 60 + hour * 60 * 60;
    //    }
    //}
}
