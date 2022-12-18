namespace Lab10
{
    internal class Var43
    {
        private int[,] _array;

        public Var43(int M)
        {
            _array = new int[M, M]; // Создаем массив(матрицу)

            Program.FillArray(_array, true); // Заполняем его

            Program.PrintArray(_array); // Выводим на экран

            List<float> result = DiagonalsAvarage(_array); // Лист средних арифм. диагоналей
            foreach (var item in result)
                Console.Write(item + " "); // Выводим все его элементы


        }
        
        private List<float> Diagonal(int[,] array, int diagonalNum) // Метод возвращающий элементы заданной диагонали
        {
            List<float> result = new(); // Лист элементов диагонали

            for (int i = 0; i < array.GetLength(0); i++) // Перебираем все строки
            {
                for (int j = 0; j < array.GetLength(1); j++) // Перебираем все столбцы
                {
                    if (i + diagonalNum != j) // Если пропускаем итерацию, в которой элементы не находятся на данной диагонали
                        continue;
                    result.Add(array[i, j]); // Записываем элемент в лист
                }
            }

            return result; // Возвращаем лист
        }
        private List<float> DiagonalsAvarage(int[,] array) // Метод для нахождения среднего значения диагоналей
        {
            List<float> diagonalsAvarage = new(); // Лист средних значений
            
            for (int i = array.GetLength(0) - 1; i >= 0; i--) // Перебираем диагонали, параллельных главной, начиная с правого верхнего элемента
                diagonalsAvarage.Add(Diagonal(array, i).Average()); // Записываем в лист среднее значение текущей диагонали
            for (int i = 1; i < array.GetLength(0); i++) // Т.к предыдущий цикл идет то i = 0, т.е до главной диагонали, то следующий цикл будет перебирать диагонали ниже главной
                diagonalsAvarage.Add(Diagonal(array, -i).Average()); // Записываем в лист среднее значение текущей диагонали

            return diagonalsAvarage; // Возвращаем лист средних значений
        }
    }
}
