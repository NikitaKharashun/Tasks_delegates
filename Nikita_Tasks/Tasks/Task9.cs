using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task9
    {
        public static Action Numbers = () =>
        {
            int from = 2;
            int to = 7;

            for (; from <= to; from++)
            {
                for (int j = 0; j < from; j++)
                    Console.Write($"{from} ");

                Console.WriteLine();
            }
        };
    }
}
