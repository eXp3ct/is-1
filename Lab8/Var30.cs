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

            foreach(var item in array) // Перебираем все элементы массива
            {
                if (_unique.Contains(item)) // Если лист содержит в себе текущее значение массива, то пропускаем итерацию цикла
                    continue;
                _unique.Add(item); // Добавляем в лист уникальное значение 
            }

            return _unique.Count; // Возвращаем количество элементов листа
        }
    }
}
