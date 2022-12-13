/* Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длинна которого меньше либо задать на старте выполнения
алгоритма. */

string[] arrayStrings = {"Hello", "2", "world", ":-)"};
ShowArray(arrayStrings);
int countWord = CoutingWords(arrayStrings);
string[] result = new string[countWord];
result = SelectingWordsFromArray(arrayStrings, countWord);
ShowResult(result);

// Функция выводит массив на экан
string ShowArray(string[] arrayStrings)
{
    int i = 0;
    Console.Write("[");
    while (i < arrayStrings.Length)
    {
        Console.Write($"'{arrayStrings[i]}' ");
        i++;
    }
    Console.Write("] ");
    return "";
}

// Функция считает кол-во слов из массива длинная которых меньше или равна 3
int CoutingWords(string[] arrayStrings)
{
    int countW = 0;
    for (int i = 0; i < arrayStrings.Length; i++)
    {
        if (arrayStrings[i].Length <= 3)
        {
            countW++;
        }
    }
    return countW;
}

// Функция выбирает слова которые содержат 3 или менее символов
string[] SelectingWordsFromArray(string[] arrayStrings, int CountW)
{
    int i = 0;
    int x = 0;
    string[] WordsFromArray = new string[CountW];

    while (i < arrayStrings.Length)
    {
        if (arrayStrings[i].Length <= 3)
        {
            WordsFromArray[x] = arrayStrings[i];
            x++;
            i++;
        }
        else { i++; }
    }
    return WordsFromArray;
}

// Функция выводит результат на экран
void ShowResult(string[] result)
{
    int i = 0;
    Console.Write("-> [");
    while (i < result.Length)
    {
        if (result.Length - i == 1)
        {
            Console.Write($"'{result[i]}'");
        }
        else {Console.Write($"'{result[i]}', ");}
        i++;
    }
    Console.Write("]");
}
