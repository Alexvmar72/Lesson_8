/*  Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49  */

using System;
using static System.Console;
Clear();

int Prompt(string message)
{
    Write(message);
    int num_result = int.Parse(ReadLine()!);
    return num_result;
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

int[,] MultiplicacionNumber(int[,] array1, int[,] array2)
{
    int k = array1.GetLength(0);
    int l = array1.GetLength(1);
    int[,] result = new int[k, l];
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < l; j++)
        {

            result[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return result;
}

int m = Prompt("Введите размер массивов по строкам: ");
int n = Prompt("Введите размер массивов по столбцам: ");
int[,] array1 = GetArray(m, n);
int[,] array2 = GetArray(m, n);

PrintArray(array1);
WriteLine();
PrintArray(array2);
WriteLine();
PrintArray(MultiplicacionNumber(array1, array2));