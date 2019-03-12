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
                Console.WriteLine("3. Zadanie 3.1 - Kryptosystem przestawieniowy dla dowolnego klucza(2b)");
                Console.WriteLine("4. Zadanie 3.2 - Kryptosystem przestawieniowy dla dowolnego klucza(2c)");
                Console.WriteLine("5. Zadanie 4 - Szyfr cezara 2b");
                Console.WriteLine("6. Zadanie 5 - Tablica Vigenere'a");
                String c = Console.ReadLine();

                switch(c)
                {
                    case "1":
                        RailFenceMenu();
                        break;
                    case "2":
                        Matrix1Menu();
                        break;
                    case "3":
                        Matrix2Menu();
                        break;
                    case "4":
                        Matrix3Menu();
                        break;
                    case "5":
                        CaesarMenu();
                        break;
                    case "6":
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

                        //kontynuacja jakbyśmy chcieli odszyfrować to co właśnie zaszyfrowaliśmy
                        Console.WriteLine("1.Odszyfruj");
                        Console.WriteLine("2.Wróć");

                        String c1 = Console.ReadLine();

                        switch (c1)
                                {
                                  case "1":
                                        wynik1 = RailFence.RailFenceDecipher(klucz1, wynik1);
                                        Console.WriteLine("Wynik odszyfrowania to: " + wynik1);
                                        Console.ReadKey();
                                        break;
                                    case "2":
                                        break;
                                }                 
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Podaj ciąg znaków");
                        string text = Console.ReadLine();

                        Console.WriteLine("Podaj klucz");
                        int klucz = Int32.Parse(Console.ReadLine());

                        string wynik = RailFence.RailFenceDecipher(klucz, text);
                        Console.WriteLine("Wynik odszyfrowania to: " + wynik);

                        //kontynuacja jakbyśmy chcieli... 
                        Console.WriteLine("1.Zaszyfruj");
                        Console.WriteLine("2.Wróć");

                        c1 = Console.ReadLine();
                        switch (c1)
                        {
                            case "1":
                                wynik1 = RailFence.RailFenceDecipher(klucz, wynik);
                                Console.WriteLine("Wynik zaszyfrowania to: " + wynik1);
                                Console.ReadKey();
                                break;
                            case "2":
                                break;
                        }
                        break;
                    case "3":
                        return;
                }
            }

        }

        public static void Matrix1Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Zadanie 2 -  Kryptosystem przestawieniowy 2a");
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

                        Console.WriteLine("Podaj liczność klucza");
                        int d1 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj klucz (format : int-int-int-...-int)");
                        string klucz1 = Console.ReadLine();

                        string wynik1 = Matrix1.Encrypt(text1,klucz1,d1);
                        Console.WriteLine("Wynik szyfrowania to: " + wynik1);

                        //kontynuacja jakbyśmy chcieli odszyfrować to co właśnie zaszyfrowaliśmy
                        Console.WriteLine("1.Odszyfruj");
                        Console.WriteLine("2.Wróć");

                        String c1 = Console.ReadLine();

                        switch (c1)
                        {
                            case "1":
                                wynik1 = Matrix1.Decrypt(wynik1, klucz1, d1);
                                Console.WriteLine("Wynik odszyfrowania to: " + wynik1);
                                Console.ReadKey();
                                break;
                            case "2":
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Podaj ciąg znaków");
                        string text = Console.ReadLine();

                        Console.WriteLine("Podaj liczność klucza");
                        int d = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj klucz (format : int-int-int-...-int)");
                        string klucz = Console.ReadLine();

                        string wynik = Matrix1.Decrypt(text, klucz, d);
                        Console.WriteLine("Wynik odszyfrowania to: " + wynik);

                        //kontynuacja jakbyśmy chcieli... 
                        Console.WriteLine("1.Zaszyfruj");
                        Console.WriteLine("2.Wróć");

                        c1 = Console.ReadLine();
                        switch (c1)
                        {
                            case "1":
                                wynik = Matrix1.Encrypt(wynik, klucz, d);
                                Console.WriteLine("Wynik zaszyfrowania to: " + wynik);
                                Console.ReadKey();
                                break;
                            case "2":
                                break;
                        }
                        break;
                    case "3":
                        return;
                }
            }

        }

        public static void Matrix2Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Zadanie 3.1 - Kryptosystem przestawieniowy dla dowolnego klucza(2b)");
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

                        string wynik1 = Matrix2.Encrypt(text1, klucz1);
                        Console.WriteLine("Wynik szyfrowania to: " + wynik1);

                        //kontynuacja jakbyśmy chcieli odszyfrować to co właśnie zaszyfrowaliśmy
                        Console.WriteLine("1.Odszyfruj");
                        Console.WriteLine("2.Wróć");

                        String c1 = Console.ReadLine();

                        switch (c1)
                        {
                            case "1":
                                wynik1 = Matrix2.Decrypt(wynik1, klucz1);
                                Console.WriteLine("Wynik odszyfrowania to: " + wynik1);
                                Console.ReadKey();
                                break;
                            case "2":
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Podaj ciąg znaków");
                        string text = Console.ReadLine();

                        Console.WriteLine("Podaj klucz");
                        string klucz = Console.ReadLine();

                        string wynik = Matrix2.Decrypt(text, klucz);
                        Console.WriteLine("Wynik odszyfrowania to: " + wynik);

                        //kontynuacja jakbyśmy chcieli... 
                        Console.WriteLine("1.Zaszyfruj");
                        Console.WriteLine("2.Wróć");

                        c1 = Console.ReadLine();
                        switch (c1)
                        {
                            case "1":
                                wynik = Matrix2.Encrypt(wynik, klucz);
                                Console.WriteLine("Wynik zaszyfrowania to: " + wynik);
                                Console.ReadKey();
                                break;
                            case "2":
                                break;
                        }
                        break;
                    case "3":
                        return;
                }
            }

        }

        public static void Matrix3Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Zadanie 3.1 - Kryptosystem przestawieniowy dla dowolnego klucza(2c)");
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

                        string wynik1 = Matrix3.Encrypt(text1, klucz1);
                        Console.WriteLine("Wynik szyfrowania to: " + wynik1);

                        //kontynuacja jakbyśmy chcieli odszyfrować to co właśnie zaszyfrowaliśmy
                        Console.WriteLine("1.Odszyfruj");
                        Console.WriteLine("2.Wróć");

                        String c1 = Console.ReadLine();

                        switch (c1)
                        {
                            case "1":
                                wynik1 = Matrix3.Decrypt(wynik1, klucz1);
                                Console.WriteLine("Wynik odszyfrowania to: " + wynik1);
                                Console.ReadKey();
                                break;
                            case "2":
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Podaj ciąg znaków");
                        string text = Console.ReadLine();

                        Console.WriteLine("Podaj klucz");
                        string klucz = Console.ReadLine();

                        string wynik = Matrix3.Decrypt(text, klucz);
                        Console.WriteLine("Wynik odszyfrowania to: " + wynik);

                        //kontynuacja jakbyśmy chcieli... 
                        Console.WriteLine("1.Zaszyfruj");
                        Console.WriteLine("2.Wróć");

                        c1 = Console.ReadLine();
                        switch (c1)
                        {
                            case "1":
                                wynik = Matrix3.Encrypt(wynik, klucz);
                                Console.WriteLine("Wynik zaszyfrowania to: " + wynik);
                                Console.ReadKey();
                                break;
                            case "2":
                                break;
                        }
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

                        if (!modInverse(klucz2))
                        {
                            Console.WriteLine("Drugi klucz nie jest relatywnie pierwszy względem 26");
                            Console.ReadKey();
                            break;
                        }

                        Caesar caesar = new Caesar(klucz1, klucz2);

                        string wynik1 = caesar.CaesarEncrypt(text1);
                        Console.WriteLine("Wynik szyfrowania to: " + wynik1);


                        //kontynuacja jakbyśmy chcieli odszyfrować to co właśnie zaszyfrowaliśmy
                        Console.WriteLine("1.Odszyfruj");
                        Console.WriteLine("2.Wróć");

                        String c1 = Console.ReadLine();

                        switch (c1)
                        {
                            case "1":
                                wynik1 = caesar.CaesarDecrypt(wynik1);
                                Console.WriteLine("Wynik odszyfrowania to: " + wynik1);
                                Console.ReadKey();
                                break;
                            case "2":
                                break;
                        }

                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Podaj ciąg znaków");
                        string text = Console.ReadLine();

                        Console.WriteLine("Podaj pierwszy klucz");
                        int klucz = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj drugi klucz");
                        int klucz3 = Int32.Parse(Console.ReadLine());

                        if(!modInverse(klucz3))
                        {
                            Console.WriteLine("Drugi klucz nie jest relatywnie pierwszy względem 26");
                            Console.ReadKey();
                            break;
                        }

                        Caesar caesar1 = new Caesar(klucz, klucz3);

                        string wynik = caesar1.CaesarDecrypt(text);
                        Console.WriteLine("Wynik odszyfrowania to: " + wynik);

                        //kontynuacja jakbyśmy chcieli... 
                        Console.WriteLine("1.Zaszyfruj");
                        Console.WriteLine("2.Wróć");

                        c1 = Console.ReadLine();
                        switch (c1)
                        {
                            case "1":
                                wynik = caesar1.CaesarEncrypt(wynik);
                                Console.WriteLine("Wynik zaszyfrowania to: " + wynik);
                                Console.ReadKey();
                                break;
                            case "2":
                                break;
                        }
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


                        //kontynuacja jakbyśmy chcieli odszyfrować to co właśnie zaszyfrowaliśmy
                        Console.WriteLine("1.Odszyfruj");
                        Console.WriteLine("2.Wróć");

                        String c1 = Console.ReadLine();

                        switch (c1)
                        {
                            case "1":
                                wynik1 = Vignere.decipherText(wynik1, klucz1);
                                Console.WriteLine("Wynik odszyfrowania to: " + wynik1);
                                Console.ReadKey();
                                break;
                            case "2":
                                break;
                        }

                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Podaj ciąg znaków");
                        string text = Console.ReadLine();

                        Console.WriteLine("Podaj klucz");
                        string klucz = Console.ReadLine();

                        string wynik = Vignere.decipherText(text, klucz);
                        Console.WriteLine("Wynik odszyfrowania to: " + wynik);

                        //kontynuacja jakbyśmy chcieli... 
                        Console.WriteLine("1.Zaszyfruj");
                        Console.WriteLine("2.Wróć");

                        c1 = Console.ReadLine();
                        switch (c1)
                        {
                            case "1":
                                wynik = Vignere.cipherText(wynik, klucz);
                                Console.WriteLine("Wynik zaszyfrowania to: " + wynik);
                                Console.ReadKey();
                                break;
                            case "2":
                                break;
                        }
                        break;
                    case "3":
                        return;
                }
            }
        }
        public static bool modInverse(int key1)
        {
            for (int x = 1; x < 27; x++)
            {
                if ((key1 * x) % 26 == 1) return true;
            }

            return false;
        }
    }
}
