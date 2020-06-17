using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            string userInput = Console.ReadLine();
            int stairSize = int.Parse(userInput);

            String[] staircase = new String[stairSize];


            for (int i = 0; i<staircase.Length; i++)
            {
                staircase[i] = " ";
            }


                for(int j = stairSize; j > 0; j--)
                {
                    staircase[j-1] = "#";

                    for (int k = 0; k < stairSize; k++){
                          Console.Write(staircase[k]);
                    }
                    Console.WriteLine("");
                }
        }
    }
}
