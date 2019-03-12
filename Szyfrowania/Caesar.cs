using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Szyfrowania
{
    class Caesar
    {

        private int key0, key1, key1Decipher;

        public Caesar(int key0,int key1)
        {
            this.key0 = key0;
            this.key1 = key1;
            this.key1Decipher = key1;
        }

        public String CaesarEncrypt(string text)
        {
            String encrypted = "";

            for (int i = 0; i < text.Length; i++)
            {
                int x = Convert.ToInt32(text[i] - 65);
                encrypted += Convert.ToChar(mod((key1*x+key0),26)+65);
            }

            return encrypted;
        }

        public String CaesarDecrypt(string text)
        {
            String decrypted = "";
            int keyInverse = modInverse(key1);
            for (int i = 0; i < text.Length; i++)
            {
                int x = Convert.ToInt32(text[i] - 65);
                if (x - key0 < 0) x = Convert.ToInt32(x) + 26;
                decrypted += Convert.ToChar(mod((keyInverse * (x - key0)),26) + 65);
            }
            return decrypted;
        }

        public int modInverse(int key1)
        {
           for(int x=1; x<27;x++)
            {
                if (mod((key1 * x), 26) == 1) return x;
            }

            throw new Exception("No multiplicative found!");
        }

        int mod(int x, int m)
        {
            return (x % m + m) % m;
        }
    }
}
