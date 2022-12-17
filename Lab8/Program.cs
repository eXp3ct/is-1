using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; // Цвет шрифта в консоли
            Console.WriteLine("Введите размер массива N: ");
            //ExecuteVariant18(); // Запуск выполнения варианта 18
            ExecuteVariant30(); // Запуск выполнение варианта 30
        }

        private static void ExecuteVariant30()
        {
            int N = int.Parse(Console.ReadLine()); // Вводим размерность
            Var30 var30 = new(N); // Создаем экземляр варианта 30 и передаем ему размерность массива
            if (N < 1) // Если размерность меньше еденицы, то выкидываем ошибку
                throw new InvalidOperationException();
        }

        private static void ExecuteVariant18()
        {
            int N = int.Parse(Console.ReadLine()); // Вводим размерность
            if(N < 1) // Если размерность меньше еденицы, то выкидываем ошибку
                throw new InvalidOperationException();
            Console.WriteLine("Введите K и L (K<=L)");
            int K = int.Parse(Console.ReadLine()); // Вводим K и L
            int L = int.Parse(Console.ReadLine());
            if (K <= 1 || K > L || L > N) // Проверяем условия, если не подходит, то выкидываем ошибку
                throw new InvalidOperationException();
            Var18 var18 = new(N, K, L); // Создаем экземляр варианта 18 и передаем ему аргументы
        }

        public static void PrintArray(int[] array) // Вывод массива
        {
            foreach(var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void FillArray(int[] array) // Заполнение массива с клавиатуры
        {
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
