using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Szyfrowania
{
    class Caesar
    {

        private String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private int euler = 11;
        private int alphabet_lenght = 26;
        private Dictionary<int, char> caesarAlphabet;
        private int key0, key1, key1Decipher;

        public Caesar(int key0,int key1)
        {
            this.key0 = key0;
            this.key1 = key1;
            this.key1Decipher = key1;

            for(int i=0;i < euler;i++)
            {
                key1Decipher = (key1Decipher * key1) % alphabet_lenght;
            }

            this.caesarAlphabet = new Dictionary<int, char>();

            for (int i = 1; i <= alphabet_lenght; i++)
            {
                caesarAlphabet.Add(i, alphabet[i-1]);
            }
        }

        public String CaesarEncrypt(string text)
        {
            String encrypted = "";

            for (int i = 0; i < text.Length; i++)
            {
                int charValue = caesarAlphabet.FirstOrDefault(x => x.Value == text[i]).Key;

                int value = (charValue*key1) + key0;
                value = value % alphabet_lenght;

                encrypted += caesarAlphabet.GetValueOrDefault(value);
            }

            return encrypted;
        }

        public String CaesarDecrypt(string text)
        {
            String decrypted = "";
            int keyInverse = modInverse(key1);
            for (int i = 0; i < text.Length; i++)
            {
                int charValue = caesarAlphabet.FirstOrDefault(x => x.Value == text[i]).Key;

                if (charValue - key0 < 0) charValue += 26;
                int value = (keyInverse * (charValue - key0)) % 26;

                decrypted += caesarAlphabet.GetValueOrDefault(value);
            }
            return decrypted;
        }

        public int modInverse(int key1)
        {
           for(int x=1; x<27;x++)
            {
                if ((key1 * x) % 26 == 1) return x;
            }

            throw new Exception("No multiplicative found!");
        }
    }
}
