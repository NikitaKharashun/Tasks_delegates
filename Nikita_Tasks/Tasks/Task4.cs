using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task4
    {
        public static Action ChangeToUpper = () =>
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();

            char[] symbols = text.ToLower().ToCharArray();

            for (int i =0; i < symbols.Length; i++)
            {
                byte charByte = Convert.ToByte(symbols[i]);

                charByte -= charByte < (byte)122 && charByte > (byte)97 ? (byte)0 : (byte)32;
                symbols[i] = Convert.ToChar(charByte);
            }

            text = new string(symbols);

            Console.WriteLine($"Преобразованный текст => {text}");
        };
    }
}
