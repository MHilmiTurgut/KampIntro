using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("hilmi");
            isimler.Add("Ali");
            isimler.Add("Semih");
            Console.WriteLine("LEngth of MyList :" + isimler.Count);
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine();

            isimler.Print();

            isimler.Add("baran");
            Console.WriteLine(  );
            Console.WriteLine(  );

            Console.WriteLine("Length of MyLİst :" + isimler.Count);
            isimler.Print();
        }
    }
}
