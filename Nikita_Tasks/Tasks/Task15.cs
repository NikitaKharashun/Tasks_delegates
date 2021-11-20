using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_Tasks.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task15
    {
        public static readonly Random rnd = new Random();
        public static void FindSum()
        {
            int[,] mass = new int[5, 5];

            int rows = mass.GetUpperBound(0) + 1;
            int columns = mass.Length / rows;

            int iMin = 0;
            int iMax = 0;

            int jMin = 0;
            int jMax = 0;

            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < columns; i++)
                {
                    mass[j, i] = rnd.Next(-100, 100);

                    int x = mass[i, j];
                    if (x < mass[iMin, jMin])
                    {
                        iMin = i;
                        jMin = j;
                    }
                    else if (x > mass[iMax, jMax])
                    {
                        iMax = i;
                        jMax = j;
                    }
                }
            }
        }
    }
}

