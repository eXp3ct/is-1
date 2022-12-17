namespace Lab9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива N: ");
            //ExecuteVariant14();
            //ExecuteVariant27();
        }

        private static void ExecuteVariant27() // Выполнение варианта 27
        {
            int N = int.Parse(Console.ReadLine()); // Вводим размерность массива
            Var27 var27 = new(N); // Создаем экземляр варианта 27 и передаем ему размерность массива
        }

        private static void ExecuteVariant14() // Выполнение варианта 14
        {
            int N = int.Parse(Console.ReadLine()); // Вводим размерность
            if (N % 2 != 0) // Если она нечетная, то кидаем ошибку
                throw new InvalidOperationException("N must be even");
            Var14 var14 = new(N); // Создаем экземляр варианта 14 и передаем ему размерность массива
        }

        public static void PrintArray(int[] array) // Вывод массива
        {
            Console.WriteLine("<-----||----->");
            foreach (var item in array)
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
        public static void FillArray(int[] array, bool random) // Заполнение массива случайными числами
        {
            if(!random)
                FillArray(array);
            Random randomValue = new(DateTime.Now.Millisecond);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomValue.Next(1, 10);
            }
        }
    }
}
