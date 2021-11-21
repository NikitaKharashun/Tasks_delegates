using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task6
    {
        public static Action AmountOfSquares = () =>
        {
            Console.WriteLine("Введите длину прямоугольника: ");
            int.TryParse(Console.ReadLine(), out int rectangleLenght);

            Console.WriteLine("Введите ширину прямоугольника: ");
            int.TryParse(Console.ReadLine(), out int rectangleWidth);

            Console.WriteLine("Введите длину квадрата: ");
            int.TryParse(Console.ReadLine(), out int sideOfSquare);

            int rectaglesArea = rectangleLenght * rectangleWidth;
            int areaOfSquare = sideOfSquare * sideOfSquare;

            if (rectaglesArea >= areaOfSquare)
                Console.WriteLine(rectaglesArea / areaOfSquare == 1 ? $"Площадь квадрата равна площади прямоугольника" : $"Количество квадратов: {rectaglesArea / areaOfSquare}");
            else
                Console.WriteLine("Ни одного");
        };
    }
}
