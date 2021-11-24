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

            // Task 4
            Task4.ChangeToUpper();

            // Task 5
            Task5.NumberDesc();

            // Task 6
            Task6.AmountOfSquares();           

            // Task 7
            Task7.Money();           

            // Task 8
            Task8.SpaceCounter();

            // Task 9
            Task9.Numbers();

            // Task 10
            Task10.ReversedNumber();

            // Task 11
            Task11.TextEditor();            

            // Task 12
            Task12.IsPalindrome();

            // Task 13
            Task13.WordCounterFirstVersion();
            Task13.WordCounterSecondVersion();

            // Task 14
            Task14.EndsWithVowel();          

            // Task 16
            Task16.GetMax();  


            Console.ReadKey();
        }
    }
}
