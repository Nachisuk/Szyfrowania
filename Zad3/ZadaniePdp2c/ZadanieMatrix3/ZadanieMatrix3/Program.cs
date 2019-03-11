using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieMatrix3
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

            for (i = 0; i < key.Length; i++)
            {
                keySorted.Add(new KeyValuePair<char, int>(key[i], i+1));
            }


            keySorted.Sort((pair1, pair2) => pair1.Key.CompareTo(pair2.Key));

            foreach(var letter in keySorted)
            {
                int ileZnakow = letter.Value;
                int tmpIndx = letter.Value-1;
                foreach(var item in keySorted)
                {
                    if (item.Value>=ileZnakow)
                    {
                        if (tmpIndx < M.Length)
                            C = C + M[tmpIndx];
                    }
                    tmpIndx = tmpIndx + item.Value;
                }
            }

            Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}
