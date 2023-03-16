/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

using System;
using static System.Console;
Clear();

int Prompt(string message)
{
    Console.Write(message);
    int num_result = int.Parse(Console.ReadLine()!);
    return num_result;
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    int x = 1;
    int i = 0;
    int j;
    int a = 0;
    int b = 0;
    int index = 1;

    while (index < result.GetLength(0) * result.GetLength(1))
    {

        for (j = b; j < n; j++)
        {

            result[i, j] = x;
            x++;
            index++;
        }

        for (i = a + 1, j--; i < m; i++)
        {
            result[i, j] = x;
            x++;
            index++;
        }
        for (j = n - 2, i--; j >= b; j--)
        {
            result[i, j] = x;
            x++;
            index++;
        }
        for (i = m - 2, j++; i > a; i--)
        {
            result[i, j] = x;
            x++;
            index++;
        }

        i++;
        a++;
        b++;
        m = m - 1;
        n = n - 1;
        index++;
    }


    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]}", 4);
        }
        WriteLine();
    }
}


int m = Prompt("Введите размер массива по строкам: ");
int n = Prompt("Введите размер массива по столбцам: ");
int[,] array = GetArray(m, n);

PrintArray(array);
