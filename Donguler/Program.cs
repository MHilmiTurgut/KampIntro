﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı ";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs ";
            string kurs3 = "Java Programalama Kursu ";

            // array 
            string[] kurslar = new string[] {"Yazılım ", "Programlama", "Java " };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine();
            Console.WriteLine("For bitti..");
            Console.WriteLine();
            foreach (string kurs  in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
