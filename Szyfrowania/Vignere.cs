using System;
using System.Collections.Generic;
using System.Text;

namespace Szyfrowania
{
    public class Vignere
    {
        public static String prepareKey(String key, int desiredlength)
        {
            String pom = "";
            int i = 0;
            int mod = key.Length;
            while(pom.Length < desiredlength)
            {
                i = i % mod;
                pom += key[i];
                i++;
            }
            return pom;
        }

        public static String cipherText(string text, string key)
        {
            text = text.ToUpper();
            key = key.ToUpper();

            //if (text.Length > key.Length) key = prepareKey(key, text.Length);
            int j = 0;
            String cipher = "";
            for(int i=0; i< text.Length;i++)
            {
                if (text[i] < 65)
                {
                    // cipher += text[i]; //to zostawia znaki specjalne spoza naszego alfabetu kto co lubie tak na prawdę na razie zakomentowane
                    continue;
                }
                int x = (text[i] + key[j]) % 26;
                x += 'A';
                cipher += (char)x;
                if (++j == key.Length) j = 0;
            }
            return cipher;
        }

        public static String decipherText(string text, string key)
        {
            text = text.ToUpper();
            key = key.ToUpper();

            //if (text.Length > key.Length) key = prepareKey(key, text.Length);
            String cipher = "";
            int j = 0; ;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] < 65)
                {
                   // cipher += text[i]; //to zostawia znaki specjalne spoza naszego alfabetu kto co lubie tak na prawdę na razie zakomentowane
                    continue;
                }
                int x = (text[i] - key[j] +26) % 26;
                x += 'A';
                cipher += (char)x;
                if (++j == key.Length) j = 0;
            }
            return cipher;
        }
    }
}
