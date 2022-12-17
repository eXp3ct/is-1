
namespace Lab9
{
    internal class Var14
    {
        private int[] _array;
        public Var14(int N)
        {
            _array = new int[N]; // Создаем массив
            Program.FillArray(_array); // Заполняем его
            Program.PrintArray(_array); // Выводим исходный массив
            _array = SwapArrayParts(_array); // Преобразовываем его
            Program.PrintArray(_array); // Выводим получившийся массив
        }

        private int[] SwapArrayParts(int[] array)
        {
            int[] result = new int[array.Length]; // Массив результат длиной оригинального

            for (int i = array.Length / 2; i < array.Length; i++) // Начиная с середниы массива перебираем все элементы
                result[i - array.Length/2] = array[i]; // Записываем в результат со смещением на array.Length/2 значение элементов массива array
            for (int i = 0; i < array.Length/2; i++) // Теперь идем с начала до середина исходного массива 
                result[i + array.Length/2] = array[i]; // Так же записваем в результат со смещением

            return result;// Возвращаем результат
        }
    }
}
