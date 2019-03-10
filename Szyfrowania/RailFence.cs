using System;
using System.Collections.Generic;
using System.Text;

namespace Szyfrowania
{
    public class RailFence
    {
        public static String RailFenceCipher(int height, String cypher)
        {
            //wzór na cykl to (x*2)-2, gdzie x to ilość railsów u nas height, a -2 bo góra i dół
            int cycle = (height * 2) - 2;
            int cypher_lenght = cypher.Length;

            float pom = cypher_lenght / cycle;
            int full_cycles =(int) Math.Round(pom, MidpointRounding.ToEven);

            String encrypted = "";

            String[] tablica = new String[height];
            int i = 0;
            int j = 0;
            for(int z=0;z<height;z++)
            {
                i = z;
                while(i<cypher_lenght)
                {        
                    if(z == 0 || z == height-1)
                    {
                        tablica[z] += cypher[i];
                        i = i + cycle;
                    }
                    else
                    {
                        int pom1 = i + (cycle - (2 * z));
                        if (pom1 >= cypher_lenght)
                        {
                            tablica[z] += cypher[i];
                            i = i + cycle;
                        }
                        else
                        {
                            tablica[z] += cypher[i];
                            tablica[z] += cypher[i + (cycle - (2 * z))];
                            i = i + cycle;
                        }              
                    }
                }
            }
            for(int z=0;z<height;z++)
            {
                encrypted += tablica[z];
            }
            return encrypted;
        }

        public static String RailFenceDecipher(int height, String cypher)
        {
            int cypher_lenght = cypher.Length;

            List<List<int>> rail = new List<List<int>>();
            for (int i = 0; i < height; i++) rail.Add(new List<int>());

            int fence_height = 0;
            int increase = 1;

            for(int i = 0; i< cypher_lenght;i++)
            {
                if(fence_height+increase == height)
                {
                    increase = -1;
                }
                else if(fence_height + increase == -1)
                {
                    increase = 1;
                }
                rail[fence_height].Add(i);
                fence_height += increase;
            }

            int c = 0;
            char[] buffor = new char[cypher_lenght];
            for(int i=0;i<height;i++)
            {
                for(int j =0; j< rail[i].Count;j++)
                {
                    buffor[rail[i][j]] = cypher[c];
                    c++;
                }
            }
            return new string(buffor);
        }
    }

   
}
