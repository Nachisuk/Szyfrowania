using System;

namespace Szyfrowania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String text = "ATTACK AT DAWN";
            String key = "LEMON";

            String wynik = Vignere.cipherText(text,key);

            Console.WriteLine(wynik);
            Console.WriteLine(Vignere.decipherText(wynik, key));
            Console.ReadKey();
        }
    }
}
