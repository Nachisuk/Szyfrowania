using System;

namespace Szyfrowania
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("1. Zadanie 1 - Rail fence");
                Console.WriteLine("2. Zadanie 2 -  Kryptosystem przestawieniowy 2a");
                Console.WriteLine("3. Zadanie 3 - Kryptosystem przestawieniowy dla dowolnego klucza(b i c)");
                Console.WriteLine("4. Zadanie 4 - Szyfr cezara 2b");
                Console.WriteLine("5. Zadanie 5 - Tablica Vigenere'a");
                String c = Console.ReadLine();

                switch(c)
                {
                    case "1":
                        RailFenceMenu();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        CaesarMenu();
                        break;
                    case "5":
                        VignereMenu();
                        break;
                }
            }
        }

        public static void RailFenceMenu()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Zadanie 1 - Rail fence");
                Console.WriteLine("1. Szyfrowanie");
                Console.WriteLine("2. Odszyfrowanie");
                Console.WriteLine("3. Powrót");
                String c = Console.ReadLine();

                switch (c)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Podaj ciąg znaków");
                        string text1 = Console.ReadLine();

                        Console.WriteLine("Podaj klucz");
                        int klucz1 = Int32.Parse(Console.ReadLine());

                        string wynik1 = RailFence.RailFenceCipher(klucz1, text1);
                        Console.WriteLine("Wynik szyfrowania to: " + wynik1);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Podaj ciąg znaków");
                        string text = Console.ReadLine();

                        Console.WriteLine("Podaj klucz");
                        int klucz = Int32.Parse(Console.ReadLine());

                        string wynik = RailFence.RailFenceDecipher(klucz, text);
                        Console.WriteLine("Wynik odszyfrowania to: " + wynik);
                        Console.ReadKey();
                        break;
                    case "3":
                        return;
                }
            }

        }
        public static void CaesarMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Zadanie 4 - Szyfr Cezara");
                Console.WriteLine("1. Szyfrowanie");
                Console.WriteLine("2. Odszyfrowanie");
                Console.WriteLine("3. Powrót");
                String c = Console.ReadLine();

                switch (c)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Podaj ciąg znaków");
                        string text1 = Console.ReadLine();

                        Console.WriteLine("Podaj pierwszy klucz");
                        int klucz1 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj drugi klucz");
                        int klucz2 = Int32.Parse(Console.ReadLine());

                        Caesar caesar = new Caesar(klucz1, klucz2);

                        string wynik1 = caesar.CaesarEncrypt(text1);
                        Console.WriteLine("Wynik szyfrowania to: " + wynik1);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Podaj ciąg znaków");
                        string text = Console.ReadLine();

                        Console.WriteLine("Podaj pierwszy klucz");
                        int klucz = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj drugi klucz");
                        int klucz3 = Int32.Parse(Console.ReadLine());

                        Caesar caesar1 = new Caesar(klucz, klucz3);

                        string wynik = caesar1.CaesarEncrypt(text);
                        Console.WriteLine("Wynik odszyfrowania to: " + wynik);
                        Console.ReadKey();
                        break;
                    case "3":
                        return;
                }
            }
        }
        public static void VignereMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Zadanie 5 - Tablica Vigenere'a");
                Console.WriteLine("1. Szyfrowanie");
                Console.WriteLine("2. Odszyfrowanie");
                Console.WriteLine("3. Powrót");
                String c = Console.ReadLine();

                switch (c)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Podaj ciąg znaków");
                        string text1 = Console.ReadLine();

                        Console.WriteLine("Podaj klucz");
                        string klucz1 = Console.ReadLine();

                        string wynik1 = Vignere.cipherText(text1, klucz1);
                        Console.WriteLine("Wynik szyfrowania to: " + wynik1);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Podaj ciąg znaków");
                        string text = Console.ReadLine();

                        Console.WriteLine("Podaj klucz");
                        string klucz = Console.ReadLine();

                        string wynik = Vignere.cipherText(text, klucz);
                        Console.WriteLine("Wynik odszyfrowania to: " + wynik);
                        Console.ReadKey();
                        break;
                    case "3":
                        return;
                }
            }
        }
    }
}
