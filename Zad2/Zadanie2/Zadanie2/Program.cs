using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {

            int d, i, k, mult_max, curr_letter_indx;
            String key, M, C=""; //M - wejscie, C - wyjscie

            //tmp
            //d = 5;
            d = 4;
            M = "CRYPTOGRAPHYOSA";
            key = "3-1-4-2";
            //key = "3-4-1-5-2";


            int[] keyArray = new int[d];
            for(i=0; i<d; i++)
            {
                keyArray[i] = Int32.Parse(key.Split('-')[i]);
            }

            mult_max = M.Length / d;

            if (mult_max*d != M.Length)
            {
                mult_max++;
            }
            
            for(i=0;i<mult_max;i++)
            {
                for(k=0;k<d;k++)
                {
                    curr_letter_indx = i * d + (keyArray[k] - 1);
                    if (curr_letter_indx < M.Length)
                        C = C + M[curr_letter_indx];
                }
            }

            Console.WriteLine(C);

            Console.ReadKey();
        }
    }
}
