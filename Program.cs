//2. Строка и символ
Console.Write("Введите строку: ");
string text = Console.ReadLine()?? "";


//3. Перебор и подсчёт символов
int CountCharacter(string text, char target)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (symbol == target)
        {
            count++;
        }
    }
    return count;
}





//4. Буквы и цифры
int CountDigits(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsDigit(symbol))
        {
            count++;
        }
    }
    return count;
}

int CountLetters(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsLetter(symbol))
        {
            count++;
        }
    }
    return count;
}




//5. Поиск символа и его индекса
int FindCharacterIndex(string text, char target)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            return i;
        }
    }
    return -1;
}



//6. Преобразование строк
string sample = " Привет, C#! ";
string trimmed = sample.Trim();
string upper = sample.ToUpper();
string lower = sample.ToLower();
string replaced = sample.Replace(' ', '_');



//7. Разделение строки на слова
int CountWords(string text){
    string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}


//8. Основная часть — «Анализатор строки»
Console.WriteLine();
Console.WriteLine(">>> Анализ строки <<<");

Console.WriteLine();
Console.WriteLine($"Исходная строка: [{text}]");
Console.WriteLine($"Длина: {text.Length}");
Console.WriteLine($"Букв: {CountLetters(text)}");
Console.WriteLine($"Цифр: {CountDigits(text)}");
Console.WriteLine($"Пробелов: {CountCharacter(text, ' ')}");
Console.WriteLine($"Слов: {CountWords(text)}");
Console.WriteLine($"Без пробелов по краям: [{text.Trim()}]");
Console.WriteLine($"Верхний регистр: [{text.ToUpper()}]");
Console.WriteLine($"Замена пробелов: [{text.Replace(' ', '_')}]");
Console.WriteLine();

Console.Write("Введите один символ для поиска: ");
char target = Convert.ToChar(Console.ReadLine());

int index = FindCharacterIndex(text, target);

if (index == -1){
    Console.WriteLine("Символ не найден");
} else {
    Console.WriteLine($"Первый индекс: {index}");
} 

//13. Самостоятельное задание
int CountWordsManually(string text){
    int count = 0;
    for (int i = 0; i < text.Length; i++){
        if (text[i] != ' ' && (i == 0 || text[i-1] == ' ')){
            count++;
        }
    } 
    return count;
} 

Console.WriteLine($"Слова без Split(): {CountWordsManually(text)}");
