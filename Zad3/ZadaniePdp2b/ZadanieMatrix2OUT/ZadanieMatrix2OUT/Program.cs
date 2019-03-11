using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieMatrix2OUT
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            String M = "";
            //String key = "CONVENIENCE";
            //String C = "HECRNCEYIISEPSGDIRNTOAAESRMPNSSROEEBTETIAEEHS";
            String key = "KAPPA";
            String C = "LOAAKATMA";

            int ifNotFullRows = C.Length % key.Length; //0 -> jest full rows - bez reszzty
            int numFullRows = C.Length / key.Length;

            List<KeyValuePair<char, int>> keySorted = new List<KeyValuePair<char, int>>();
            List<KeyValuePair<char, int>> keyUnsorted = new List<KeyValuePair<char, int>>();
            int[] indxStartForKeyChar = new int[key.Length];

            for (i = 0; i < key.Length; i++)
            {
                KeyValuePair<char, int> tmp = new KeyValuePair<char, int>(key[i], i + 1);
                keyUnsorted.Add(tmp);
                keySorted.Add(tmp);
            }
            keySorted.Sort((pair1, pair2) => pair1.Key.CompareTo(pair2.Key));

            i = 0;
            foreach(var item in keySorted)
            {
                indxStartForKeyChar[keyUnsorted.IndexOf(item)] = i;
                i += numFullRows;
                if (ifNotFullRows != 0 && keyUnsorted.IndexOf(item) + 1 <= ifNotFullRows)
                    i++;
            }

            for(i=0; i<(ifNotFullRows==0?numFullRows:numFullRows+1); i++)
            {
                int indexToThrow=i;
                foreach(var item in keyUnsorted)
                {
                    indexToThrow = indxStartForKeyChar[keyUnsorted.IndexOf(item)]+i;
                    if (indexToThrow < C.Length)
                        M = M + C[indexToThrow];
                    if (M.Length >= C.Length)
                        break;
                }
            }

            Console.WriteLine(M);
            Console.ReadKey();
        }
    }
}
