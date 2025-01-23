/*
Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Начальные условия:

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 
*/
using System;

class Program
{
    static void Main()
    {
        int[,] numbers = new int[,] {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        Console.WriteLine("Исходный массив:");
        PrintMatrix(numbers);

        SwapFirstAndLastRows(numbers);

        Console.WriteLine("\nМассив после обмена первой и последней строк:");
        PrintMatrix(numbers);
    }

    static void SwapFirstAndLastRows(int[,] array)
    {
        int rowCount = array.GetLength(0);

        if (rowCount >= 2)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[0, j];
                array[0, j] = array[rowCount - 1, j];
                array[rowCount - 1, j] = temp;
            }
        }
        else
        {
            Console.WriteLine("Массив слишком мал для обмена строк.");
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}