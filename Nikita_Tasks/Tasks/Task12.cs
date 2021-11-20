using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task12
    {
        public static Action IsPalindrome = () =>
        {
            Console.WriteLine("Введите строку для теста: ");
            string testPalindrome = Console.ReadLine();

            char[] charMass = testPalindrome.ToCharArray();
            string reverse = "";

            for (int i = charMass.Length - 1; i > -1; i--)
                reverse += charMass[i];

            Console.WriteLine(testPalindrome.Equals(reverse) ? "Это палиндром" : "Это не палиндром");
        };
    }
}
