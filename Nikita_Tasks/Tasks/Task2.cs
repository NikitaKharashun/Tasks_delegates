using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task2
    {
        public delegate double GetArea(int x1, int y1, int x2, int y2, int x3, int y3);

        public static Func<int, int, int, int, double> getSide = (x1, y1, x2, y2) => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        public static Func<int, int, int, int, int, int, double> getPerimeter = (x1, y1, x2, y2, x3, y3) => getSide(x1, y1, x2, y2) + getSide(x2, y2, x3, y3) + getSide(x3, y3, x1, y1);


        public static GetArea getArea = (x1, y1, x2, y2, x3, y3) =>
        {
            double halfPerimeter = getPerimeter(x1, y1, x2, y2, x3, y3) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - (getSide(x1, y1, x2, y2))) * (halfPerimeter - (getSide(x1, y1, x2, y2))) * (halfPerimeter - (getSide(x1, y1, x2, y2))));
        };
    }
}
