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
            ValidateInputString(words.ToList());
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
        private void ValidateInputString(List<string> trimmedWords)
        {
            if (trimmedWords.Count < 1 || trimmedWords.Count > 30) // Проверка на допустимое количество слов
                throw new InvalidCastException("Недопустимое количество слов");
            foreach (var word in trimmedWords) // Проверка на заглавные буквы
                if (!ValidateUppercase(word))
                    throw new IOException("Слова не должны содержать заглавные буквы");
            foreach (var word in trimmedWords) // Проверка на содержание кириллицы
                if (ValidateCyrillic(word))
                    throw new IOException("Слова должны состоять из латинских букв");
            foreach (var word in trimmedWords)
                if (word.Length < 1 || word.Length > 5)
                    throw new IOException("Недопустимая длина слова");
        }
        private bool ValidateUppercase(string str)
        {
            if (int.TryParse(str, out int _)) // Если входной параметр - это число, то слово валидное
                return true;
            for (int i = 0; i < str.Length; i++) // Перебираем все символы в слове
            {
                if (str[i] == str.ToUpper()[i]) // Если символ - это заглавный символ, то слово невалидное
                    return false;
            }
            return true; // Если ничего не вернули раньше, то слово валидное
        }
        private bool ValidateCyrillic(string str)
        {
            var cyrillic = Enumerable.Range(1024, 256).Select(ch => (char)ch); // Символы кириллицы
            return str.Any(cyrillic.Contains); // проверяем содержит ли входное слово символы кириилицы, если содержит, то true, иначе false
        }
    }
}
