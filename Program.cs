using System;
using System.Collections.Generic;

namespace Koleksiyonlar___Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Personel = new Dictionary<int, string>();

            Personel.Add(1, "Personel 1");
            Personel.Add(2, "Personel 2");
            Personel.Add(3, "Personel 3");
            Personel.Add(4, "Personel 4");
            Personel.Add(5, "Personel 5");

            foreach (var item in Personel) Console.WriteLine(item);
                       
            Console.ReadKey();

        }
    }
}
