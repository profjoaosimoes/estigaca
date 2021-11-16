using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_with_strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Sou Pro do Rocket");

            //Console.WriteLine("Sou Pro do \nRocket"); // \n paragraph

            //Console.WriteLine("Sou Pro do \"Rocket\""); // \" print "

            //Console.WriteLine("Sou Pro do \nRocket");

            /*string player = "Sou noob do Rocket";
            Console.WriteLine(player);*/

            /*string player = "Sou noob do Rocket";
            Console.WriteLine(player.Length);*/ //methods

             /*string player = "Sou noob do Rocket";
            Console.WriteLine(player.ToUpper());*/

             string player = "Sou noob do Rocket";
            Console.WriteLine(player.Contains("Rocket")); //params

            /*string player = "Sou noob do Rocket";
           Console.WriteLine(player[9]);*/ //index 

            /*string player = "Sou noob do Rocket";
            Console.WriteLine(player.IndexOf("noob"));*/ //index where "noob" starts

            /*string player = "Sou noob do Rocket";
            //Console.WriteLine(player.Substring(4)); //starts at index 4 
            Console.WriteLine(player.Substring(4,6));*/ //starts at index 4 and shows the following 4 chars
            
            Console.ReadLine();
        }
    }
}
