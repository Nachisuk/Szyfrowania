using System;
using System.Collections.Generic;
using System.Text;

namespace Szyfrowania
{
    static class Matrix3
    {
        public static String Encrypt (String _input, String _key)
        {
            int i;
            //String key = "CONVENIENCE";
            //String M = "HEREISASECRETMESSAGEENCIPHEREDBYTRANSPOSITION";
            //String key = "KAPPA";
            //String M = "ALAMAKOTA";
            String key = _key;
            String M = _input;
            String C = "";

            List<KeyValuePair<char, int>> keySorted = new List<KeyValuePair<char, int>>();
            int sum = 0;
            for (i = 0; i < key.Length; i++)
            {
                keySorted.Add(new KeyValuePair<char, int>(key[i], i + 1));
                sum += i + 1;
            }

            keySorted.Sort((pair1, pair2) => pair1.Key.CompareTo(pair2.Key));

            int howManyRep = M.Length / sum;
            if(M.Length%sum != 0)
            {
                howManyRep++;
            }

            foreach (var letter in keySorted)
            {
                int ileZnakow = letter.Value;
                int tmpIndx = letter.Value - 1;
                for(i=0;i<howManyRep;i++)
                {
                    foreach (var item in keySorted)
                    {
                        if (item.Value >= ileZnakow)
                        {
                            if (tmpIndx < M.Length)
                                C = C + M[tmpIndx];
                        }
                        tmpIndx = tmpIndx + item.Value;
                    }
                }
                
            }



            return C;
        }

        public static String Decrypt(String _input, String _key)
        {
            int i;
            String M = "";
            //String key = "CONVENIENCE";
            //String C = "HECRNCEYIISEPSGDIRNTOAAESRMPNSSROEEBTETIAEEHS";
            //String key = "KAPPA";
            //String C = "LOAAKATMA";
            String key = _key;
            String C = _input;

            M = M.PadLeft(C.Length);
            char[] mArray = M.ToCharArray();
            int sum = 0;

            List<KeyValuePair<char, int>> keySorted = new List<KeyValuePair<char, int>>();
            for (i = 0; i < key.Length; i++)
            {
                keySorted.Add(new KeyValuePair<char, int>(key[i], i + 1));
                sum += i + 1;
            }
            keySorted.Sort((pair1, pair2) => pair1.Key.CompareTo(pair2.Key));

            int howManyRep = M.Length / sum;
            if (M.Length % sum != 0)
            {
                howManyRep++;
            }


            int numRows = 0, tmpSum = 0;

            for(i=0;i<howManyRep;i++)
            {
                foreach (var item in keySorted)
                {
                    tmpSum += item.Value;
                    numRows++;
                    if (tmpSum >= C.Length)
                        break;
                }
            }
            


            int indxToThrow = 0;
            foreach (var item in keySorted)
            {
                int columnIndx = item.Value - 1;



                int indxToInsert = columnIndx;
                int currRow = 0;
                for(i = 0; i< howManyRep; i++)
                {
                    foreach (var rowLetter in keySorted)
                    {
                        if (currRow >= numRows || indxToInsert >= mArray.Length)
                            break;
                        //else
                        if (rowLetter.Value >= item.Value)
                        {
                            mArray[indxToInsert] = C[indxToThrow];
                            indxToThrow++;
                        }
                        indxToInsert += rowLetter.Value;
                        currRow++;
                    }
                }
                
            }

            M = new String(mArray);

            return M;
        }
    }
}
