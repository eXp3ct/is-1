namespace Lab10
{
    internal class Program
    {
        private static int _n = 0;
        private static int _m = 0;
        public static void Main(string[] args)
        {
            //ExecuteVariant24();
            ExecuteVariant43();
        }

        private static void ExecuteVariant43()
        {
            Console.WriteLine("Введите порядок матрицы M: ");
            _n = int.Parse(Console.ReadLine()); // Вводим размер матрицы
            Var43 var43 = new(_n); // Создаем экземляр класса 43 и передаем ему размер
        }

        private static void ExecuteVariant24()
        {
            Console.WriteLine("Введите размерность матрицы MxN: ");
            _n = int.Parse(Console.ReadLine()); // Вводим размеры матрицы
            _m = int.Parse(Console.ReadLine());
            Var24 var24 = new(_n, _m); // Создаем экземляр класса 24 и передаем ему размер
        }

        public static void PrintArray(int[,] array) // Вывод массива
        {
            Console.WriteLine("<-----||----->");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void FillArray(int[,] array) // Заполнение массива с клавиатуры
        {
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void FillArray(int[,] array, bool random) // Заполнение массива случайными числами
        {
            if (!random)
                FillArray(array);
            Random randomValue = new(DateTime.Now.Millisecond);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = randomValue.Next(1, 10);
                }
            }
        }
    }

}
