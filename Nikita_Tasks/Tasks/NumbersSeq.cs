using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class NumbersSeq
    {
        public delegate void Numbers(int a, int b);

        public static Numbers numbers = (a, b) =>
        {
            for (; a <= b; a++)
            {
                for (int j = 0; j < a; j++)
                    Console.Write(a + " ");
                Console.WriteLine();
            }
        };
    }
}
