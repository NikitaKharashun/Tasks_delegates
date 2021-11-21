using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task10
    {
        public static Action ReversedNumber = () =>
        {
            Console.WriteLine("Введите число: ");
            int.TryParse(Console.ReadLine(), out int number);

            char[] numbers = number.ToString().ToCharArray();
            string reversedNumber = "";

            for (int i = numbers.Length - 1; i > -1; i--)
                reversedNumber += numbers[i];

            Console.WriteLine($"Перевернутое число: {reversedNumber}");
        };
    }
}
