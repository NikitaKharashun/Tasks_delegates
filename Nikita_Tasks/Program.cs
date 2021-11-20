using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_Tasks.Tasks;

namespace Nikita_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine(Task1.ToCelsius(248));
            Console.WriteLine(new string('-', 32));

            //Task 2
            Console.WriteLine($"Сторона 1 => {Task2.getSide(1, 1, 2, 4)}, сторона 2 => {Task2.getSide(2, 4, 4, 2)}, сторона 3 => {Task2.getSide(4, 2, 1, 1)}");
            Console.WriteLine($"Периметр => {Task2.getPerimeter(1, 1, 2, 4, 4, 2)}");
            Console.WriteLine($"Площадь => {Task2.getArea(1, 1, 2, 4, 4, 2)}");
            Console.WriteLine(new string('-', 32));

            // Task 3           
            Task3.IsLucky();
            Console.WriteLine(new string('-', 32));

            // Task 5
            Task5.NumberDesc();
            Console.WriteLine(new string('-', 32));

            // Task 6
            Task6.AmountOfSquares();
            Console.WriteLine(new string('-', 32));

            // Task 8
            Task8.SpaceCounter();
            Console.WriteLine(new string('-', 32));

            // Task 9
            Task9.Numbers();
            Console.WriteLine(new string('-', 32));

            // Task 12
            Task12.IsPalindrome();
            Console.WriteLine(new string('-', 32));

            // Task 14
            Task14.EndsWithVowel();
            Console.WriteLine(new string('-', 32));

            // Task 15
            Task16.GetMax();
            Console.WriteLine(new string('-', 32));

            // Task 16



            Console.ReadKey();
        }
    }
}
