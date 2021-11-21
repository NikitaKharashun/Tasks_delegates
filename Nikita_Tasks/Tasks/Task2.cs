using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task2
    {
        public static Func<int, int, int, int, double> GetSide = (x1, y1, x2, y2) => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        public static Func<int, int, int, int, int, int, double> GetPerimeter = (x1, y1, x2, y2, x3, y3) => GetSide(x1, y1, x2, y2) + GetSide(x2, y2, x3, y3) + GetSide(x3, y3, x1, y1);


        public static Func<int, int, int, int, int, int, double> GetArea  = (x1, y1, x2, y2, x3, y3) =>
        {
            double halfPerimeter = GetPerimeter(x1, y1, x2, y2, x3, y3) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - (GetSide(x1, y1, x2, y2))) * (halfPerimeter - (GetSide(x1, y1, x2, y2))) * (halfPerimeter - (GetSide(x1, y1, x2, y2))));
        };
    }
}
