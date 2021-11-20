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

            Console.WriteLine("Введите длину прямоугольника: ");
            int.TryParse(Console.ReadLine(), out int sideOfSquare);

            int rectaglesArea = rectangleLenght * rectangleWidth;
            int AreaOfSquare = sideOfSquare * sideOfSquare;
            if (rectaglesArea >= AreaOfSquare)
                Console.WriteLine((rectaglesArea %= AreaOfSquare) == 0 ? $"Площадь квадрата равна площади прямоугольника" : $"Количество квадратов: {rectaglesArea /= AreaOfSquare}");
            else
                Console.WriteLine("Ни одного");
        };
    }
}
