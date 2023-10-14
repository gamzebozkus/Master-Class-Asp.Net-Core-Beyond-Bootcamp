using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "C#";
            string kurs2 = "Java";
            string kurs3 = "Angular";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            //array
            string[] kurslar = new string[] { "C#", "Java", "Angular" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string s in kurslar)
            {
                Console.WriteLine(s);
            }
        }
    }
}
