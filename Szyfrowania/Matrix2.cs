using System;
using System.Collections.Generic;
using System.Text;

namespace Szyfrowania
{
    static class Matrix2
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
                while (throwIndex < M.Length)
                {
                    C = C + M[throwIndex];
                    throwIndex = throwIndex + key.Length;
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
            foreach (var item in keySorted)
            {
                indxStartForKeyChar[keyUnsorted.IndexOf(item)] = i;
                i += numFullRows;
                if (ifNotFullRows != 0 && keyUnsorted.IndexOf(item) + 1 <= ifNotFullRows)
                    i++;
            }

            for (i = 0; i < (ifNotFullRows == 0 ? numFullRows : numFullRows + 1); i++)
            {
                int indexToThrow = i;
                foreach (var item in keyUnsorted)
                {
                    indexToThrow = indxStartForKeyChar[keyUnsorted.IndexOf(item)] + i;
                    if (indexToThrow < C.Length)
                        M = M + C[indexToThrow];
                    if (M.Length >= C.Length)
                        break;
                }
            }

            return M;
        }
    }
}
