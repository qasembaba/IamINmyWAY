using System;

namespace IamINmyWAY
{
    class Program


    {

     // declaring methods 
      static void CompereNumbers()

        {
            int numberOne;
            int numberTwo;

            Console.WriteLine("Please enter a number:");
            numberOne = TextToNumber(Console.ReadLine());

            Console.WriteLine("Please enter a number: ");
            numberTwo = TextToNumber(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine(" First number was the biggest");

            }
            else
            {
                Console.WriteLine("Second number was the biggest");

            }

        }
        static int TextToNumber(string TextToNumber)

        {
            int number = 0;

            ReadOnlySpan<char> textNumber = default;
            int.TryParse(textNumber, out number);

            return number;
        }

    }

} 
            



        

   
