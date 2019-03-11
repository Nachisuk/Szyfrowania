using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieMatrix3Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            String M = "";
            //String key = "CONVENIENCE";
            //String C = "HEESPNIRRSSEESEIYASCBTEMGEPNANDICTRTAHSOIEERO";
            String key = "KAPPA";
            String C = "LMOAATAAK";
            
            M = M.PadLeft(C.Length);
            char[] mArray = M.ToCharArray();

            List<KeyValuePair<char, int>> keySorted = new List<KeyValuePair<char, int>>();
            for (i = 0; i < key.Length; i++)
            {
                keySorted.Add(new KeyValuePair<char, int>(key[i], i + 1));
            }
            keySorted.Sort((pair1, pair2) => pair1.Key.CompareTo(pair2.Key));

            int numRows = 0, tmpSum=0;

            foreach(var item in keySorted)
            {
                tmpSum += item.Value;
                numRows++;
                if (tmpSum >= C.Length)
                    break;
            }

            int indxToThrow = 0;
            foreach(var item in keySorted)
            {
                int columnIndx = item.Value - 1;

                int indxToInsert = columnIndx;
                int currRow = 0;
                foreach(var rowLetter in keySorted)
                {
                    if (currRow >= numRows || indxToInsert >= mArray.Count())
                        break;
                    //else
                    if (rowLetter.Value>=item.Value)
                    {
                        mArray[indxToInsert] = C[indxToThrow];
                        indxToThrow++;
                    }
                    indxToInsert += rowLetter.Value;
                    currRow++;
                }
            }

            M = new String(mArray);

            Console.WriteLine(M);
            Console.ReadKey();
        }
    }
}
