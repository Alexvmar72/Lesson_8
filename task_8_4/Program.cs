/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)             */

using System;
using static System.Console;
Clear();

int Prompt(string message)
{
    Write(message);
    int num_result = int.Parse(ReadLine()!);
    return num_result;
}

int[,,] GetArray(int m)
{
    int[,,] result = new int[m, m, m];
    int x = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int e = 0; e < m; e++)
            {
                result[i, j, e] = x;
                x++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int e = 0; e < array.GetLength(2); e++)
            {
                Write($"{array[i, j, e]}({i},{j},{e}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
}

int m = Prompt("Введите размер массива не больше 4: ");
if (m > 4) WriteLine($"Введите размер массива не больше 4");
else
{
    int[,,] array = GetArray(m);
    PrintArray(array);
}