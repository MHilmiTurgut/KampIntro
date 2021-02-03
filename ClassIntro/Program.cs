using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "hilmi ";
            int yas = 22;

            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin";
            kurs1.IzlenmeOrani = 70;



            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "Java ";
            kurs2.Egitmen = "koray";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "python ";
            kurs3.Egitmen = "berkay";
            kurs3.IzlenmeOrani = 74;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.Egitmen);
            }
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
