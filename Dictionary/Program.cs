using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            Console.WriteLine("Length of myDictionary::" + myDictionary.Count);
            myDictionary.Add(1, "Hilmi");
            myDictionary.Add(2, "Baran");
            myDictionary.Add(3, "Ali");
            Console.WriteLine("Length of myDictionary::" + myDictionary.Count);
            myDictionary.Print();





        }
    }
}
//var kullanicilarDict = new Dictionary<int, string >();
//var kullanicilarSort = new SortedList<int, string >();

//kullanicilarDict.Add(5, "hilmi");
//kullanicilarDict.Add(1,"ali");
//kullanicilarDict.Add(0,"Baran");
//kullanicilarDict.Add(3, "eşref");
//kullanicilarDict.Add(4, "ata");
//kullanicilarDict.Add(2, "semih");

//kullanicilarSort.Add(5, "hilmi");
//kullanicilarSort.Add(1, "ali");
//kullanicilarSort.Add(0, "Baran");
//kullanicilarSort.Add(3, "eşref");
//kullanicilarSort.Add(4, "ata");
//kullanicilarSort.Add(2, "semih");
//Console.WriteLine("By using Dictionary::");
//foreach (KeyValuePair<int,string> kullanici in kullanicilarDict)
//{
//    Console.WriteLine("Kullanıcı ID:" + kullanici.Key + "  " + "Kullanıcı ismi: " + kullanici.Value);
//}
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine("By using SortedList::");
//foreach (KeyValuePair<int, string> kullanici in kullanicilarSort)
//{
//    Console.WriteLine("Kullanıcı ID:" + kullanici.Key + "  " + "Kullanıcı ismi: " + kullanici.Value);
//}