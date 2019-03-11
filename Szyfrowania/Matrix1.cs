using System;
using System.Collections.Generic;
using System.Text;

namespace Szyfrowania
{
    static class Matrix1
    {
        public static String Encrypt(String _input, String _key, int _d)
        {
            int d, i, k, mult_max, curr_letter_indx;
            String key, M, C = ""; //M - wejscie, C - wyjscie

            //tmp
            //d = 5;
            //d=4;
            d = _d;
            M = _input;
            key = _key;
            //M = "CRYPTOGRAPHYOSA";
            //key = "3-1-4-2";
            //key = "3-4-1-5-2";


            int[] keyArray = new int[d];
            for (i = 0; i < d; i++)
            {
                keyArray[i] = Int32.Parse(key.Split('-')[i]);
            }

            mult_max = M.Length / d;

            if (mult_max * d != M.Length)
            {
                mult_max++;
            }

            for (i = 0; i < mult_max; i++)
            {
                for (k = 0; k < d; k++)
                {
                    curr_letter_indx = i * d + (keyArray[k] - 1);
                    if (curr_letter_indx < M.Length)
                        C = C + M[curr_letter_indx];
                }
            }

            return C;
        }

        public static String Decrypt(String _input, String _key, int _d)
        {
            int d, i, k, mult_max, curr_letter_indx;
            String key, M = "", C; //M - wyjscie, C - wejscie (zakodowane slowo)

            //tmp
            //d = 5;
            //d = 4;
            d = _d;
            //C = "YPCTRRAOPGOSHAY";
            //C = "YCPRGTROHAYPAOS";
            C = _input;
            //key = "3-4-1-5-2";
            //key = "3-1-4-2";
            key = _key;

            SortedDictionary<int, int> newKeys = new SortedDictionary<int, int>();
            for (i = 0; i < d; i++)
            {
                newKeys.Add(Int32.Parse(key.Split('-')[i]), i + 1);
            }

            mult_max = C.Length / d;

            SortedDictionary<int, int> newLastKeys = null;

            if (mult_max * d != C.Length)
            {
                mult_max++;

                newLastKeys = new SortedDictionary<int, int>();
                k = 1;
                for (i = 0; i < d; i++)
                {
                    int tmp = Int32.Parse(key.Split('-')[i]);
                    curr_letter_indx = (mult_max - 1) * d + (tmp - 1);
                    if (curr_letter_indx < C.Length)
                    {
                        newLastKeys.Add(tmp, k);
                        k++;
                    }
                }
            }

            for (i = 0; i < mult_max; i++)
            {
                if (i == mult_max - 1 && newLastKeys != null)
                {
                    for (k = 0; k < (C.Length % d); k++)
                    {
                        curr_letter_indx = i * d + (newLastKeys[k + 1] - 1);
                        if (curr_letter_indx < C.Length)
                            M = M + C[curr_letter_indx];
                    }
                }
                else
                {
                    for (k = 0; k < d; k++)
                    {

                        curr_letter_indx = i * d + (newKeys[k + 1] - 1);
                        if (curr_letter_indx < C.Length)
                            M = M + C[curr_letter_indx];
                    }
                }
            }


            return M;
        }

    }
}
