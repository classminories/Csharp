using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndDoRiddles
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Who is the father of the electricity?");
            string crossRoad = Console.ReadLine().ToLower();
            while (crossRoad != "nicolas tesla") 
            {
                Console.WriteLine("Keep trying; please");
                crossRoad = Console.ReadLine().ToLower();
            }
            Console.WriteLine("What's the most amazing thing he tried but the powerful people just stop him?");
            string dangerous = Console.ReadLine().ToLower();
            do
            {
                Console.WriteLine("keep trying...I'll guive you a tip: He tried to be like Roobin Hood");
                dangerous = Console.ReadLine().ToLower();
            } while (dangerous != "free electricity");
            Console.WriteLine("Well done! You know about Nicolas Tesla!");
        }
    }
}
