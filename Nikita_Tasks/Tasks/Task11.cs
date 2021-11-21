using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task11
    {
        public static Action TextEditor = () =>
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();

            Console.WriteLine("Введите строку для замены: ");
            string stringForEdit = Console.ReadLine();

            Console.WriteLine("Введите новую строку: ");
            string newString = Console.ReadLine();


            if (text.Contains(stringForEdit))
            {
                string newText = text.Replace(stringForEdit, newString);
                Console.WriteLine($"Текст успешно изменен, новый текст => {newText}");
            }
            else           
                Console.WriteLine($"Строки {stringForEdit} нет в тексте {text}");       
        };

    }
}
