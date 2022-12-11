/* Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длинна которого меньше либо задать на старте выполнения
алгоритма. */


Messager("Введите кол-во слов в массиве: ");
string[] arrayStrings = new string[InputNumberLine()];

FillArray(arrayStrings);

Console.WriteLine("----------");
int x = 0;
while(x < arrayStrings.Length)
{
    Console.WriteLine(arrayStrings[x]);
    x++;
}

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