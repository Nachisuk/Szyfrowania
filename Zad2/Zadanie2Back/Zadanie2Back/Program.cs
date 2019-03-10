using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2Back
{
    class Program
    {
        static void Main(string[] args)
        {

            int d, i, k, mult_max, curr_letter_indx;
            String key, M = "", C; //M - wyjscie, C - wejscie (zakodowane slowo)

            //tmp
            d = 5;
            //d = 4;
            C = "YPCTRRAOPGOSHAY";
            //C = "YCPRGTROHAYPAOS";
            key = "3-4-1-5-2";
            //key = "3-1-4-2";

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
                    curr_letter_indx = (mult_max-1) * d + (tmp - 1);
                    if (curr_letter_indx < C.Length)
                    {
                        newLastKeys.Add(tmp, k);
                        k++;  
                    }
                }
            }

            for (i = 0; i < mult_max; i++)
            {
                if(i == mult_max-1 && newLastKeys != null)
                {
                    for (k = 0; k < (C.Length%d); k++)
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


            Console.WriteLine(M);

            Console.ReadKey();
        }
    }
}
