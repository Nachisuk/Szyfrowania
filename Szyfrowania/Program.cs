using System;

namespace Szyfrowania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String text = "CRYPTOGRAPHYASD";
            Caesar code = new Caesar(3,5);

            String wynik = code.CaesarEncrypt(text);

            Console.WriteLine(wynik);
            Console.WriteLine(code.CaesarDecrypt(wynik));
            Console.ReadKey();
        }
    }
}
