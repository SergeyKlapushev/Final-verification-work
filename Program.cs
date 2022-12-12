/* Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длинна которого меньше либо задать на старте выполнения
алгоритма. */

Messager("Введите кол-во слов в массиве: ");
string[] arrayStrings = new string[InputNumberLine()];
FillArray(arrayStrings);
ShowArray(arrayStrings);
string[] result = new string[arrayStrings.Length];
result = SelectingWordsFromArray(arrayStrings);

int x = 0;
Console.Write("-> [");
while(x < result.Length)
{
    Console.Write($"{result[x]}");
    x++;
}
Console.Write("]");

// Функция преднозначеная для вывода сообщений
void Messager(string message)
{
    Console.Write(message);
}

// Функция возвращает число обозначающее кол-во слов в массиве
int InputNumberLine()
{
    return Convert.ToInt32(Console.ReadLine());
}

// Функция для заполнения массива словами
string[] FillArray(string[] arrayStrings)
{
    int i = 0;
    while (i < arrayStrings.Length)
    {
        Messager($"Введите {i + 1}-е слово: ");
        arrayStrings[i] = Console.ReadLine();
        i++;
    }
    return arrayStrings;
}

// Функция выводит заполненный массив
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

string[] SelectingWordsFromArray(string[] arrayStrings)
{
    int i = 0;
    string[] WordsFromArray = new string[arrayStrings.Length];

    while(i<arrayStrings.Length)
    {
        if (arrayStrings[i].Length <=3 )
        {
            WordsFromArray[i] = arrayStrings[i];
            i++;
        }
        else{i++;}
    }
    return WordsFromArray;
}