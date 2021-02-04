using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hilmi Turgut
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Hilmi";
            musteri1.TcNo = "Turgut";
            musteri1.TcNo = "12345678910";


            //Kodlama.io 
            TüzelMüsteri musteri2 = new TüzelMüsteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";



            //Gerçek müşteri - Tüzel müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TüzelMüsteri();

        }
    }
}
