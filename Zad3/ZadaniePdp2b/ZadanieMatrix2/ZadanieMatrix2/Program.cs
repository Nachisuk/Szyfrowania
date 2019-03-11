using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieMatrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            //String key = "CONVENIENCE";
            //String M = "HEREISASECRETMESSAGEENCIPHEREDBYTRANSPOSITION";
            String key = "KAPPA";
            String M = "ALAMAKOTA";
            String C = "";

            List<KeyValuePair<char, int>> keySorted = new List<KeyValuePair<char, int>>();
            List<KeyValuePair<char, int>> keyUnsorted = new List<KeyValuePair<char, int>>();

            for (i = 0; i < key.Length; i++)
            {
                KeyValuePair<char, int> tmp = new KeyValuePair<char, int>(key[i], i + 1);
                keyUnsorted.Add(tmp);
                keySorted.Add(tmp);
            }
            keySorted.Sort((pair1, pair2) => pair1.Key.CompareTo(pair2.Key));

            int startIndx = 0;
            foreach (var letter in keySorted)
            {
                startIndx = keyUnsorted.IndexOf(letter);
                int throwIndex = startIndx;
                while(throwIndex<M.Length)
                {
                    C = C + M[throwIndex];
                    throwIndex = throwIndex + key.Length;
                }
            }

            Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}
