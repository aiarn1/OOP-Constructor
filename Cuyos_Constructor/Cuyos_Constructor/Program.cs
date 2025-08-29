using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Louis AIan Cuyos
            // IT306
            // Creating a Class


            // Methods Arguments and Initialization
            MyPerson newperson = new MyPerson("Aian", 13, "Cuyos");
            MyPerson newperson1 = new MyPerson("Carls ", 14, "Belleza");
            MyPerson newperson2 = new MyPerson("Khert ", 21, "Salon");
            MyPerson newperson3 = new MyPerson("Jack ", 20, "Yagonia");
            MyPerson newperson4 = new MyPerson("Mylene ", 15, "Miral");
            MyPerson newperson5 = new MyPerson("Mary ", 32, "Camero");
            MyPerson newperson6 = new MyPerson("Sky ", 12, "LAGUMBAY");


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Name       : " + newperson.Name + "\n" + "age        : " + newperson.Age + "\n" + "Lastname   : " + newperson.LastName + "\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Name       : " + newperson1.Name + "\n" + "age        : " + newperson1.Age + "\n" + "Lastname   : " + newperson1.LastName + "\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Name       : " + newperson1.Name + "\n" + "age        : " + newperson1.Age + "\n" + "Lastname   : " + newperson1.LastName + "\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Name       : " + newperson1.Name + "\n" + "age        : " + newperson1.Age + "\n" + "Lastname   : " + newperson1.LastName + "\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Name       : " + newperson1.Name + "\n" + "age        : " + newperson1.Age + "\n" + "Lastname   : " + newperson1.LastName + "\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Name       : " + newperson1.Name + "\n" + "age        : " + newperson1.Age + "\n" + "Lastname   : " + newperson1.LastName + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Name       : " + newperson1.Name + "\n" + "age        : " + newperson1.Age + "\n" + "Lastname   : " + newperson1.LastName + "\n");


            Console.ReadKey();


        }
    }
}
