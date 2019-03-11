using System;

namespace Szyfrowania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String text = "CRYPTOGRAPHY";
            Caesar code = new Caesar(15, 17);

            String wynik = code.CaesarEncrypt(text);

            Console.WriteLine(wynik);
            Console.WriteLine(code.CaesarDecrypt(wynik));
            Console.ReadKey();
        }
    }
}
