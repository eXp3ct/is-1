namespace Lab13
{
    internal class Var20
    {
        private string _str; // Поле входной строки
        private List<string> _result; // Поле список результатов
        public Var20()
        {
            _str = Program.EnterString(); // Вводим строку
            _result = GetPolynom(_str); // Список получает слова полиномы

            foreach(var item in _result) // Выводим на экран все слова полиномы
                Console.WriteLine(item);

        }
        private List<string> GetPolynom(string str)
        {
            List<string> trimmedWords = new(); // Усеченные слова(без пробелов)
            List<string> result = new(); // Список результатов
            str = str.TrimEnd('.'); // Убираем точку в конце
            string[] words = str.Split(' '); // Разделяем слова по пробелам в массив
            for (int i = 0; i < words.Length; i++) // Перебираем все слова в массиве
            {
                string trimmedWord = words[i].Trim(' '); // Убираем в слове все ненужные пробелы

                if (trimmedWord == string.Empty) // Если слово получилось пустым, то пропускаем итерацию цикла
                    continue;

                trimmedWords.Add(trimmedWord); // Добавляем в список усеченных слов текущее слово

            }
            ValidateInputString(trimmedWords); // Проверка всех условий
            foreach (var word in trimmedWords) // Перебираем все усеченные слова
                if (word != trimmedWords.Last() && IsPolynom(word)) // Если текущее слово не совпадает с последним словом и оно полином, то добавляем в результат
                    result.Add(word);

            return result; // Возвращаем результат
        }

        private void ValidateInputString(List<string> trimmedWords)
        {
            if (trimmedWords.Count < 1 || trimmedWords.Count > 50) // Проверка на допустимое количество слов
                throw new InvalidCastException("Недопустимое количество слов");
            foreach (var word in trimmedWords) // Проверка на заглавные буквы
                if (!ValidateUppercase(word))
                    throw new IOException("Слова не должны содержать заглавные буквы");
            foreach (var word in trimmedWords) // Проверка на содержание кириллицы
                if (ValidateCyrillic(word))
                    throw new IOException("Слова должны состоять из латинских букв");
        }

        private bool IsPolynom(string word) // Метод для проверки слова на полином
        {
            for (int i = 0; i < word.Length; i++) // перебираем все символы слова
                if (word[i] != word[word.Length - i - 1]) // если символ не совпадает с соотвествующим символом в конце, то слово - не полином
                    return false;
            
            return true; // Если не раньше ничего не вернули, то возвращаем true(т.е. слово - полином)
        }
        private bool ValidateUppercase(string str)
        {
            if(int.TryParse(str, out int _)) // Если входной параметр - это число, то слово валидное
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
