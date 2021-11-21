using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task7
    {
        public static readonly Random rnd = new Random();

        public static Action Money = () =>
        {
            double deposit = 1000;
            double procent = rnd.Next(2, 7);
            int monthsCounter = 0;

            while (deposit < 1100)
            {           
                deposit +=  deposit * (procent / 100);
                monthsCounter++;
            }

            Console.WriteLine($"Процентная ставка => {procent}");
            Console.WriteLine($"Итоговая сумма => {Convert.ToDouble(deposit)}, количество месяцев => {monthsCounter}");
        };
    }
}
