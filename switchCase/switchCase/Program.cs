using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donald, Hillary, Bernie, Ted and Ben ran to the President of the U.S.A. Who do you think should have won?");


            string president = Console.ReadLine().ToLower();
            
            //var pres1 = Donald;

            switch (president)
            {
                case "donald":
                    Console.WriteLine("This is a backward step for the humanity");
                    break;

                case "hillary":
                    Console.WriteLine("She was the right one");
                    break;

                case "bernie":
                    Console.WriteLine("I don't think this is gonna work");
                    break;
                case "ted":
                    Console.WriteLine("I don't know who is Ted");
                    break;
                case "ben":
                    Console.WriteLine("Interesting, probably would be a good president");
                    break;

            }//end of the SwitchStatement

        }//End of the main
    }
}
