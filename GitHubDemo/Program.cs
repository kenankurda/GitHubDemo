using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GitHub");
            ConsoleKeyInfo key = Console.ReadKey();
            //Console.WriteLine(key.Key.ToString());

            if (key.Key.ToString() == "Enter")
            {
                Console.WriteLine("you pressed enter");
            }
            if (key.Key.ToString() == "Escape")
            {
                Console.WriteLine("you pressed escape");
            }
            if (key.Key.ToString() == "SpaceBar")
            {
                Console.WriteLine("you pressed spacebar");
            }
            if (key.Key.ToString() == "UpArrow")
            {
                Console.WriteLine("you pressed uparrow");
            }
            if (key.Key.ToString() == "DownArrow")
            {
                Console.WriteLine("you pressed Downarrow");
            }
            if (key.Key.ToString() == "LeftArrow")
            {
                Console.WriteLine("you pressed Leftarrow");
            }
        }
    }
}
