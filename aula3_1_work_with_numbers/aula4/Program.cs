using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math Methods
            Console.WriteLine(Math.Abs(-40)); //Absolute Number - Distance from -40 to 0 which is 40, It's always POSITIVE
            Console.WriteLine(Math.Pow(3, 2)); //3^2
            Console.WriteLine(Math.Sqrt(36)); //Square Root
            Console.WriteLine(Math.Max(4, 90)); //Higher Number
            Console.WriteLine(Math.Min(4, 90)); //Lower Number
            Console.WriteLine(Math.Round(3.5,MidpointRounding.ToEven)); //Número Par + Próximo
            Console.WriteLine(Math.Round(5.5,MidpointRounding.AwayFromZero)); //Número mais próximo que esteja distante de zero
            Console.ReadLine();
        }
    }
}
