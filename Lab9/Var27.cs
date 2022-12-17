namespace Lab9
{
    internal class Var27
    {
        private int[] _array;
        public Var27(int N)
        {
            _array = new int[N]; // Создаем массив
            Program.FillArray(_array); // Заполняем его
            Console.WriteLine("Исходнйы массив"); 
            Program.PrintArray(_array); // Выводим его
            Console.WriteLine("Полученный массив");
            Program.PrintArray(NewArray(_array)); // Выводим преобразованный массив
        }
        private int[] NewArray(int[] array) //
        {
            int[] result = new int[array.Length]; // Массив результат длиной как и исходный
            int sum = 0; // Сумма элементов с 1 до K(i)
            for (int i = 0; i < array.Length; i++) // Перебираем все элементы
            {
                sum += array[i]; // Суммируем текущее значение исходного массива
                result[i] = sum; // Текущую сумму присваиваем элементу массива результата
            }

            return result; // Возрващаем результат
        }
    }
}
