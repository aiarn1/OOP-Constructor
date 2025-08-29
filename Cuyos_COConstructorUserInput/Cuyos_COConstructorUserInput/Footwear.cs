using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_COConstructorUserInput
{
    internal class Footwear
    {
        // Declaring Fields
        public string Brand;
        public string Color;
        public double Size;


        public Footwear(string aBrand, string aColor, double aSize) // Parameterize Constructors
        {
            Brand = aBrand;
            Color = aColor;
            Size = aSize;
        }

        // Method to Display
        public void DisplayFootwear()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******** Here are the Details of the Shoes you inputed *********");
            Console.WriteLine("\nEnter the Brand of your shoes: " + Brand);
            Console.WriteLine("Enter the Color of your shoes: " + Color);
            Console.WriteLine("Enter the Size of your shoes : " + Size);
        }
    }
}
