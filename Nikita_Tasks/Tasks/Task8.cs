using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task8
    {
        public static Action SpaceCounter = () =>
        {
            Console.WriteLine("Введите символы: ");
            char input = Console.ReadKey().KeyChar;
            int spaceCounter = 0;

            while (input != '.')
            {
                input = Console.ReadKey().KeyChar;
                    spaceCounter += input == ' ' ? 1 : 0;
            }
            Console.WriteLine();
            Console.WriteLine($"Было введено: {spaceCounter} пробелов");
        };
    }
}
