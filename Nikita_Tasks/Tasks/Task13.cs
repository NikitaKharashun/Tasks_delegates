using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task13
    {
        public static Action WordCounterFirstVersion = () =>
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            string[] words = text.Split(' ', ',', ';', '!', ':', ';', '.', '?');
            Console.WriteLine($"Всего слов: {words.Length}");
            Console.WriteLine(new string('-', 32));
        };

        public static Action WordCounterSecondVersion = () =>
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            char[] letters = text.ToCharArray();
            int counter = 0;

            for (int i = 0; i < letters.Length; i++)          
                counter += letters[i] == ' ' ? 1 : 0;

            Console.WriteLine($"Всего слов: {counter}");
            Console.WriteLine(new string('-', 32));
        };

    }
}
