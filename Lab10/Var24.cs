
namespace Lab10
{
    internal class Var24
    {
        private int[,] _array;
        private int _n;
        private int _m;
        public Var24(int N, int M)
        {
            _n = N;
            _m = M;
            _array = new int[_n, _m]; // Создаем массив

            Program.FillArray(_array, true); // Заполняем массив

            Program.PrintArray(_array); // Выводим его
            Console.WriteLine($"Результат: {GetLastRow(_array)}"); // Выводим результат 
        }
        private int? GetLastRow(int[,] array)
        {
            int result = 0; // Переменная результата
            int tempMax = 0; // Переменная временного максимального количества повторяющихся элементов
            int max = 0; // Переменная для максимального количества повторяющихся элементов
            string noRecurring = string.Empty;
            for (int i = 0; i < array.GetLength(0); i++) // Перебираем строки
            {
                List<int> same = new(); // Лист элементов строки
                
                for (int j = 0; j < _m; j++) // Перебираем элементы строки
                {
                    same.Add(array[i,j]); // Добавляем в лист
                }
                tempMax = same.Count - same.Distinct().Count(); // Считаем количество повторяющихся элементов (Общее количество элементов - количество различающихся)
                noRecurring = ValidateInt(tempMax);
                /*if(noRecurring == string.Empty) // DEBUG проверка строк 
                    Console.WriteLine($"<---[Строка {i + 1} || {tempMax}]--->");
                else
                    Console.WriteLine($"<---[Строка {i + 1} || {noRecurring}]--->");*/
                if (tempMax > max) // Если временный максимум больше максимума, то временный максимум становится максимумом
                {
                    max = tempMax;
                    result = i+1; // В результат сохраняем номер строки
                }
                else if(tempMax == max) // Если временный максимум равен максимуму, то просто в результат сохраняем эту строку (для получения последней строки)
                    result = i +1;
            }
            if(max == 0)
            {
                Console.WriteLine("Нет повторяющихся чисел");
                return null;
            }
            return result; // Возвращаем результат
        }
        private string ValidateInt(int value)
        {
            return value == 0 ? "нет повторяющихся чисел" : string.Empty;
        }
    }
}
