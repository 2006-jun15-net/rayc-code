using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] staircase = new String[8];

            for (int i = 0; i<staircase.Length; i++)
            {
                staircase[i] = " ";
            }


                for(int j = 7; j >= 0; j--)
                {
                    staircase[j] = "#";

                    for (int k = 0; k < 8; k++){
                          Console.Write(staircase[k]);
                    }
                    Console.WriteLine("");
                }
        }
    }
}
