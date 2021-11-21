using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task3
    {

        public static Action IsLucky = () =>
        {
            Console.WriteLine("Введите номер билета: ");
            int.TryParse(Console.ReadLine(), out int number);

            char[] numbers = number.ToString().ToCharArray();
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)           
                sum =+ i < 3 ? numbers[i] : -numbers[i];
            

            Console.WriteLine(sum == 0 ? "Ваш билет счастливый" : "Ваш билет не счастливый");
        };
    }
}
