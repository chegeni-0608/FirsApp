using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsApp
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This code is show numbers between two input numbers");
            Console.WriteLine("Enter First Number : ");
            int Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            int Num2 = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Numbers Of Between two Number Entrance is :");


            for (int i = Num1 + 1; i <= Num2 - 1; i++)
                Console.WriteLine(i);

            for (int j = Num2 + 1; j <= Num1 - 1; j++)
                Console.WriteLine(j);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************this code show numbers less than input number**************************");

            Console.WriteLine("Enter a  Number : ");
            int Number= int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers of less than Enterance Number : ");

            for(int i=1; i < Number; i++)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
 