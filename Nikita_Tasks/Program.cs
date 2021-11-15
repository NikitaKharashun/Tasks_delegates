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
            //// Task 1
            //Console.WriteLine(Temperature.convert(248));
            //Console.WriteLine(new string('-', 32));

            ////Task 2
            //Console.WriteLine($"Сторона 1 => {Triangle.getSide(1, 1, 2, 4)}, сторона 2 => {Triangle.getSide(2, 4, 4, 2)}, сторона 3 => {Triangle.getSide(4, 2, 1, 1)}");
            //Console.WriteLine($"Периметр => {Triangle.getPerimeter(1, 1, 2, 4, 4, 2)}");
            //Console.WriteLine($"Площадь => {Triangle.getArea(1, 1, 2, 4, 4, 2)}");
            //Console.WriteLine(new string('-', 32));

            //// Task 3
            //int.TryParse(Console.ReadLine(), out int numberOFTicket);
            //LuckyTicket.isLucky(numberOFTicket);
            //Console.WriteLine(new string('-', 32));

            // Task 4 ???

            // Task 5
            int rndnumber = NumbersDesc.rnd.Next(100, 999);
            NumbersDesc.numberdesc(rndnumber);
            Console.WriteLine(new string('-', 32));

            ////Task 6
            //int.TryParse(Console.ReadLine(), out int rectangleLenght);
            //int.TryParse(Console.ReadLine(), out int rectangleWidth);
            //int.TryParse(Console.ReadLine(), out int sideOfSquare);
            //Console.WriteLine(SquaresInARec.squaresInARec(rectangleLenght, rectangleWidth, sideOfSquare));
            //Console.WriteLine(new string('-', 32));

            //// Task 9
            //int from = 2;
            //int to = 7;
            //NumbersSeq.numbers(from, to);
            //Console.WriteLine(new string('-', 32));




            Console.ReadKey();
        }
    }
}
