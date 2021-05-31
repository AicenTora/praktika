using System;
using Praktika.Abstractions;

namespace Praktika.Theme1
{
    public class Task13 :ITask
    {
        public void Main()
        {
            int a3 = GetInt("a3");
            int a2 = GetInt("a2");
            int a1 = GetInt("a1");
            int b2 = GetInt("b2");
            int b1 = GetInt("b1");

            var res1 = a1 + b1;
            var overflow = DifFerenceRazr(ref res1);

            var res2 = a2 + b2 + overflow;
            var overflow2 = DifFerenceRazr(ref res2);

            var res3 = a3 + overflow2;
            
            Console.WriteLine($"Конечный результат: {res3}{res2}{res1}");
        }

        private int DifFerenceRazr(ref int number)
        {
            var raz2 = number / 10;
            number %= 10;
            return raz2;
        }

        private int GetInt(string name)
        {
            Console.Write($"Введите элемент {name}: ");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
    }
}