using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class LuckyTicket
    {
        public delegate void IsTicketLucky(int number);

        public static IsTicketLucky isLucky = (number) =>
        {
            int n1, n2, n3, n4, n5, n6;
            n6 = number / 100000;
            number -= n6 * 100000;
            n5 = number / 10000;
            number -= n5 * 10000;
            n4 = number / 1000;
            number -= n4 * 1000;
            n3 = number / 100;
            number -= n3 * 100;
            n2 = number / 10;
            n1 = number % 10;
            Console.WriteLine((n1 + n2 + n3 == n4 + n5 + n6) ? "Ваш билет счастливый" : "Ваш билет не счастливый");
        };
    }
}
