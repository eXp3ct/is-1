namespace Lab13
{
    internal class Var15
    {
        private string _str; // Поле для входной строки
        public Var15()
        { 
            _str = Program.EnterString(); // Вводим строку
            List<string> list = GetMiddleWord(_str); // Создаем лист результатов
            foreach(var item in list)
                Console.WriteLine(item); // Выводим результаты
        }
        private List<string> GetMiddleWord(string str)
        {
            List<string> result = new(); // Лист результатов
            str = str.TrimEnd('.'); // Убираем точку в конце
            string[] words = str.Split(','); // Разделяем слова через запятую
            if (words.Length < 3) // Если их меньше 3, то кидаем ошибку(просто не получится проверять соседние слова если их меньше 3)
                throw new InvalidOperationException("Слов должно быть больше 3");

            for (int i = 1; i < words.Length-1; i++) // Перебираем слова, не включая последние
            {
                for (int j = 0; j < words[i].Length; j++) // Перебираем символы в слове посередине
                {
                    if (words[i - 1][j] < words[i][j] && words[i][j] < words[i+1][j]) // Если символ слова слева меньше соотвествующего символа в слове посередине,
                        // и символ слова посередине меньше соотвествующего символа слова справа, то
                    {
                        if (result.Contains(words[i])) // Если оно уже содержится в списке, то выходим из перебора символов
                            break;
                        result.Add(words[i]); // Добавляем в список это слово
                    }
                }
            }

            return result; // Возвращаем результат
        }
    }
}
