﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace App8
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Tovar[] tovars = new Tovar[n];

            for (int i = 0; i < n; i++)
            {
            Console.WriteLine("Введите код");
            int kod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название");
            string name = Console.ReadLine();
            Console.WriteLine("Введите цену");
            int price = Convert.ToInt32(Console.ReadLine());
            tovars[i] = new Tovar() {Kod=kod, Name=name, Price=price };
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(tovars, options);

            using (StreamWriter sw = new StreamWriter("../../../Products.json"))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}
