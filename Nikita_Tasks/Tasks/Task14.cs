using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task14
    {
        public static Action EndsWithVowel = () =>
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();

            string[] words = text.Split(' ', ',', ';', '!', ':', ';', '.', '?');
            string[] vowels = new string[] { "а", "и", "е", "ё", "о", "у", "ы", "э", "ю", "я" };

            int counter = 0;
            foreach (var word in words)
            {
                foreach (var vowel in vowels)             
                        counter += word.ToLower().EndsWith(vowel) ? 1 : 0;                                                 
            }

            Console.WriteLine($"Всего слов заканчивающихся на гласную: {counter}");
            Console.WriteLine(new string('-', 32));
        };
    }
}
