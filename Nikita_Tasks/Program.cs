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
            Console.WriteLine($"Сторона 1 => {Task2.GetSide(1, 1, 2, 4)}, сторона 2 => {Task2.GetSide(2, 4, 4, 2)}, сторона 3 => {Task2.GetSide(4, 2, 1, 1)}");
            Console.WriteLine($"Периметр => {Task2.GetPerimeter(1, 1, 2, 4, 4, 2)}");
            Console.WriteLine($"Площадь => {Task2.GetArea(1, 1, 2, 4, 4, 2)}");
            Console.WriteLine(new string('-', 32));

            // Task 3           
            Task3.IsLucky();
            Console.WriteLine(new string('-', 32));

            // Task 4
            Task4.ChangeToUpper();
            Console.WriteLine(new string('-', 32));

            // Task 5
            Task5.NumberDesc();
            Console.WriteLine(new string('-', 32));

            // Task 6
            Task6.AmountOfSquares();
            Console.WriteLine(new string('-', 32));

            // Task 7
            Task7.Money();
            Console.WriteLine(new string('-', 32));

            // Task 8
            Task8.SpaceCounter();
            Console.WriteLine(new string('-', 32));

            // Task 9
            Task9.Numbers();
            Console.WriteLine(new string('-', 32));

            // Task 10
            Task10.ReversedNumber();
            Console.WriteLine(new string('-', 32));

            // Task 11
            Task11.TextEditor();
            Console.WriteLine(new string('-', 32));

            // Task 12
            Task12.IsPalindrome();
            Console.WriteLine(new string('-', 32));

            // Task 14
            Task14.EndsWithVowel();
            Console.WriteLine(new string('-', 32));

            // Task 16
            Task16.GetMax();
            Console.WriteLine(new string('-', 32));


            Console.ReadKey();
        }
    }
}
