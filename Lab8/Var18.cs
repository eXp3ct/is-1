namespace Lab8
{
    internal class Var18
    {
        private int[] _array;
        public Var18(int N, int K, int L) 
        { 
            _array = new int[N]; // Создаем массив

            Program.FillArray(_array); // Заполняем массив

            Program.PrintArray(_array); // Выводим массив

            Console.WriteLine($"Сумма : {TruncateSum(_array, K, L)}"); // Вывод суммы
            Console.WriteLine($"Произведение : {TruncateProduct(_array, K, L)}"); // Вывод произведение
        }

        private int TruncateSum(int[] array, int K, int L)
        {
            int result = 0; // Локальная переменная результата

            for (int i = 0; i < array.Length; i++) // Перебираем все элементы массива
            {
                if (i >= K-1 && i <= L-1)  // Пропускаем элементы с К по L
                    continue;
                result += array[i]; // суммируем к результату значения массива
            }

            return result; // Возвращаем результат
        }
        private int TruncateProduct(int[] array, int K, int L)
        {
            int result = 1; // Локальная переменная результата

            for (int i = 0; i < array.Length; i++) // Перебираем все элементы массива
            {
                if (i >= K - 1 && i <= L - 1) // Пропускаем элементы с K по L
                    continue;
                result *= array[i]; // домножаем к результату значение массива
            }

            return result; // Возвращаем результат
        }

    }
}
