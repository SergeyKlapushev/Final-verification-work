﻿/* Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длинна которого меньше либо задать на старте выполнения
алгоритма. */


Messager("Введите кол-во слов в массиве: ");
string[] arrayStrings = new string[InputNumberLine()];

Console.WriteLine($"");

FillArray(arrayStrings);

Console.WriteLine($"");

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

string[] FillArray(string[] arrayStrings)
{
    Console.WriteLine(arrayStrings.Length);
    return arrayStrings;
}