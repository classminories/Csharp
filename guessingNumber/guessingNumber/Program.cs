using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("In this program you will enter the numbers to help you which one is the RIGHT ONE");
            Console.WriteLine("Please type a number");

            int correct = 7;// we declare the number to guess
            int number = 0;
            do
            {

                string input = Console.ReadLine();// gets the input from the user and declares it in to INPUT
                Int32.TryParse(input, out number);//desclares the input from the user to number 
                if (number == correct)//checks if the number entered is equal to the declared number
                {
                    Console.WriteLine("you Guessed the number");
                }
                else if(number >= correct)
                {
                    Console.WriteLine("Your number is a bit high, keep trying please");
                }
                else if(number <= correct)
                {
                    Console.WriteLine("Your number is a bit low, keep trying please");
                }

            } while (number != correct);
        }//end of the main 
    }//end of the program
}

 