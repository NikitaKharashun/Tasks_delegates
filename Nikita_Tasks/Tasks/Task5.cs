using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task5
    {
        public static readonly Random rnd = new Random();

        enum SingleNumbers
        {
            один = 1,
            два = 2,
            три = 3,
            четыре = 4,
            пять = 5,
            шесть = 6,
            семь = 7,
            восемь = 8,
            девять = 9
        }
        enum DecimalNumbers
        {
            десять = 10,
            одиннадцать = 11,
            двенадцать = 12,
            тринадцать = 13,
            четырнадцать = 14,
            пятнадцать = 15,
            шестнадцать = 16,
            семнадцать = 17,
            восемнадцать = 18,
            девятнадцать = 19,
            двадцать = 20,
            тридцать = 30,
            сорок = 40,
            пятьдесят = 50,
            шестьдесят = 60,
            семьдесят = 70,
            восемьдесят = 80,
            девяносто = 90
        }
        enum Hundreds
        {
            сто = 100,
            двести = 200,
            триста = 300,
            четыреста = 400,
            пятьсот = 500,
            шестьсот = 600,
            семьсот = 700,
            восемьсот = 800,
            девятьсот = 900
        }

        public static Action NumberDesc = () =>
        {
            int number = 300; // rnd.Next(99, 999);

            int hundreds = (number / 100) * 100;
            int singleNumbers = number % 10;
            int decimals = number - hundreds - singleNumbers;


            Console.WriteLine(number - hundreds < 20 ? $"{number} => {(Hundreds)hundreds} {(DecimalNumbers)number - hundreds}" : $"{number} => {(Hundreds)hundreds} {(DecimalNumbers)(number - hundreds - singleNumbers)} {(SingleNumbers)singleNumbers}");
           
        };
    }
}
