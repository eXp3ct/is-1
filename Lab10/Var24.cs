
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
        private int GetLastRow(int[,] array)
        {
            int result = 0; // Переменная результата
            int tempMax; // Переменная временного максимального количества повторяющихся элементов
            int max = 0; // Переменная для максимального количества повторяющихся элементов
            for (int i = 0; i < _n; i++) // Перебираем строки
            {
                List<int> same = new(); // Лист элементов строки
                
                for (int j = 0; j < _m; j++) // Перебираем элементы строки
                {
                    same.Add(array[i,j]); // Добавляем в лист
                }
                tempMax = same.Count - same.Distinct().Count(); // Считаем количество повторяющихся элементов (Общее количество элементов - количество различающихся)
                //Console.WriteLine($"<---[Строка {i+1} || {tempMax}]--->"); // DEBUG проверка строк 
                if(tempMax > max) // Если временный максимум больше максимума, то временный максимум становится максимумом
                {
                    max = tempMax;
                    result = i+1; // В результат сохраняем номер строки
                }
                else if(tempMax == max) // Если временный максимум равен максимуму, то просто в результат сохраняем эту строку (для получения последней строки)
                    result = i +1;
            }
            
            return result; // Возвращаем результат
        }
    }
}
