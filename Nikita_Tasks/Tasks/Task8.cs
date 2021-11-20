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
                if (input == ' ')
                    spaceCounter++;
            }
            Console.WriteLine();
            Console.WriteLine($"Было введено: {spaceCounter} пробелов");
        };
    }
}
