using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesCS
{
    internal class Task06
    {
        public static void userInput()
        {
            Console.WriteLine("Please input an int:");
            string userInputInt = Console.ReadLine();
            Console.WriteLine("Please input a decimal:");
            string userInputDec = Console.ReadLine();

            int inputInt = Int32.Parse(userInputInt);
            decimal inputDec = Convert.ToDecimal(userInputDec);

            decimal divResult = inputInt / inputDec;
            double doubleResult = (double)divResult;

            Console.WriteLine(doubleResult);


        }

        public static void userChar()
        {
            Console.WriteLine("Please input an string:");
            string userString = Console.ReadLine();
            Console.WriteLine("Would you like the answer returned as a char array?");
            string userBool = Console.ReadLine();
            bool val = bool.Parse(userBool);
            
            if (val)
            {
                char[] myArray = userString.ToCharArray();
                Console.WriteLine(myArray);
            }

        }

    }
}
