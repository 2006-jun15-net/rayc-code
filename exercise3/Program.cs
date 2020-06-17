using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            while(number > 1)
            {
                if(number%2 == 0)
                {
                    number = number/2;
                    Console.WriteLine(number);
                }else
                {
                    number = ((number*3) +1);
                    Console.WriteLine(number);
                }

            }
        }
    }
}
