namespace Lab13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //ExecuteVariant15();
            ExecuteVariant20();
        }

        private static void ExecuteVariant20()
        {
            Console.WriteLine("Введите последовательность: ");
            Var20 var20 = new(); // Создание экземляра варианта 20
        }

        private static void ExecuteVariant15()
        {
            Console.WriteLine("Введите последовательность: ");
            Var15 var15 = new(); // Создание экземляра варианта 15
        }

        public static string EnterString() // Метод для ввода строки (чисто чтобы соблюдать общий стиль кода)
        {
            return Console.ReadLine();
        }
    }
}
