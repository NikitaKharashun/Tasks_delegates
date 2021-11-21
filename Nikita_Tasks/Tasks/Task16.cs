using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task16
    {
        public static readonly Random rnd = new Random();

        public static Action GetMax = () =>
        {
            int[,] mass = new int[5, 5];

            int max = 0;
            for (int j = 0; j < mass.GetUpperBound(0) + 1; j++)
            {
                for (int i = 0; i < mass.Length / mass.GetUpperBound(0) + 1; i++)
                {
                    mass[j, i] = rnd.Next(-100, 100);

                    max = mass[i, j] > max ? mass[i, j] : max;

                }
                Console.WriteLine($"Максимальное значение: {j + 1} = {max}");
                max = 0;
            }
        };
    }  
}
