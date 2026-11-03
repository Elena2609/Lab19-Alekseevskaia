//2. Строка и символ
string text = "Код 2026";

Console.WriteLine(text.Length);
Console.WriteLine(text[0]);
Console.WriteLine(text[text.Length - 1]);

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

Console.WriteLine(CountCharacter("мама", 'м'));
Console.WriteLine(CountCharacter("Код 2026", ' '));
Console.WriteLine(CountCharacter("", 'а'));

//Найдите ошибку: граница цикла
// int CountCharacter(string text, char target){
//     int count = 0;
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             count++;
//         }
//     } 
//     return count;
// }

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

int CountLetters(string text){
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

Console.WriteLine(CountDigits("Код 2026!"));
Console.WriteLine(CountLetters("Код 2026!"));

//Найдите ошибку: количество цифр
// int CountDigits(string text){
//     int count = 0;

//     foreach (char symbol in text)
//     {
//         if (char.IsDigit(symbol))
//         {
//             count += 1;
//         }
//     } 
//     return count;
// }

// Console.WriteLine(CountDigits("A2B3"));

//5. Поиск символа и его индекса
int FindCharacterIndex(string text, char target){
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            return i;
        }
    } 
    return -1;
}

Console.WriteLine(FindCharacterIndex("banana", 'a'));
Console.WriteLine(FindCharacterIndex("banana", 'b'));
Console.WriteLine(FindCharacterIndex("banana", 'z'));
Console.WriteLine(FindCharacterIndex("", 'a'));

//Найдите ошибку: первое совпадение
// int FindCharacterIndex(string text, char target){
//     int index = -1;

//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             index = i;
//             break;
//         }
//     }
//     return index;
// } 

