using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_COConstructorUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Main:
            // Louis Aian Cuyos
            // IT306
            // EXER_03: User Input with Constructor



            // User input
            Console.ForegroundColor = ConsoleColor.Yellow;// Color

            Console.WriteLine("\t\t\t\tEnter the Brand,Color,Size of your Favorite Shoes ");

            Console.ForegroundColor = ConsoleColor.Cyan;// Color
            Console.Write("\nEnter the Brand of your shoes : ");
            string aBrand = Console.ReadLine();

            Console.Write("Enter the Color of you shoes  : ");
            string aColor = Console.ReadLine();

            Console.Write("Enter the Size of your shoes  : ");
            double aSize = Convert.ToDouble(Console.ReadLine());


            // Instantiation of an object
            Footwear myFootwear = new Footwear(aBrand, aColor, aSize);
            myFootwear.DisplayFootwear();


            // If you want to input again
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nEnter if you want more (Y/N)");
            char i = Convert.ToChar(Console.ReadLine());

            if (i == 'Y')
            {
                goto Main;
            }
            else
            {
                return;
            }

        }
    }
}
