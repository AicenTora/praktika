using System;
using System.Reflection.Metadata;
using Praktika.Abstractions;

namespace Praktika
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notExit = true;
            do
            {
                PrintMenu();
                var answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        GetTask(new Theme1.Task13());
                        break;
                    case 0:
                        notExit = false;
                        break;
                    default:
                        Console.WriteLine("Такого значения нет! Попробуй еще раз...");
                        break;
                }
            } while (notExit);
        }

        private static void GetTask(ITask task)
        {
            task.Main();
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Выберите задачу:\n" +
                              "Тема 1:\n" +
                              "\t1) Задача 13\n" +
                              "0) Выход");
        }
    }
}