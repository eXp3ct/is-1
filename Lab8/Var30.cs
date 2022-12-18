namespace Lab8
{
    internal class Var30
    {
        private int[] _array;
        private List<int> _unique;
        public Var30(int N)
        {
            _array = new int[N]; // Создаем массив
            _unique = new List<int>(); // Лист для уникальных значений
            Program.FillArray(_array); // Заполнение массива

            Program.PrintArray(_array); // Вывод массива

            Console.WriteLine($"Результат: {FindUnique(_array)}"); // Вывод результата
        }

        private int FindUnique(int[] array)
        {
            return array.Distinct().Count(); // Возвращаем количество элементов 
        }
    }
}
