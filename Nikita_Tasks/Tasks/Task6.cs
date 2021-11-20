using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task6
    {
        public delegate int AmountOfSquares(int a, int b, int c);

        public static AmountOfSquares squaresInARec = (a, b, c) =>
        {
            int rectaglesArea = a * b;
            int AreaOfSquare = c * c;
            if (rectaglesArea >= AreaOfSquare)         
                 return  (rectaglesArea %= AreaOfSquare) == 0 ? 1 : rectaglesArea /= AreaOfSquare;
            else
                return 0;
        };
    }
}
