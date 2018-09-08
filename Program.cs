using System;

namespace CsharpM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes an input from the user, multiplies it by 50, and prints the result to the console.
            Console.WriteLine("This will be an arithmetic excersise:");
            Console.WriteLine("Please type and enter in a whole number:");
            string userInput = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("We will now multiply the whole number by Fifty:");
            Console.ReadLine();

            int multiply = 50 * Convert.ToByte(userInput);
            Console.WriteLine("This is your whole number multiplied by Fifty :"+ multiply);

            //Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Now, Please enter a whole number:");
            Console.ReadLine();
            string secInput = Console.ReadLine();
            int InputConvert = int.Parse(Console.ReadLine());
            int sumNum = InputConvert + 25;
            Console.ReadLine();
            Console.WriteLine("This is your whole number added to Twenty Five:" + " " + sumNum );

            // Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Now, please input a number so that we can divide by 12.5:");
            Console.ReadLine();
            string thirdInput = Console.ReadLine();
            double qout = Convert.ToDouble(thirdInput) / 12.5;
            Console.ReadLine();
            Console.WriteLine("This is your input divided by 12.5:"+ qout);
            Console.ReadLine();

            //Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
            Console.WriteLine();
            string fourthResponse = Console.ReadLine();
            int fourthNumConvert = int.Parse(Console.ReadLine());

            if (fourthNumConvert > 50) 
            {
            Console.WriteLine("Your whole number is greater than Fifty!:");
            }

            else 
             { Console.WriteLine("Your number is not greater than Fifty!:");
             }
            Console.ReadLine();

            //Takes an input from the user, divides it by 7, and prints the remainder to the console.
            Console.WriteLine("Please enter a whole number so that we can divide that number by Seven:");
            string responseFour = Console.ReadLine();
            double responseConvertTwo = Convert.ToDouble(responseFour);
            double modulator = responseConvertTwo % 7;
            Console.WriteLine("This is your number divided by 7 with a remainder: " + modulator);
        }
    }
}
