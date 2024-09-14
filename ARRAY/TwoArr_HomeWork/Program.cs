/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет: 
"Позиция по рядам выходит за пределы массива"
или "Позиция по колонкам выходит за пределы массива"

Позиции в массиве считать от единицы.
В коде, начальные условия:

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};
int x = 2;
int y = 2;
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

        int x = 2;
        int y = 2;

        int result = GetArrayElement(numbers, x, y);

        if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента: {result}");
        }
    }

    static int GetArrayElement(int[,] array, int row, int column)
    {
        int rowCount = array.GetLength(0);
        int columnCount = array.GetLength(1);

        if (row >= 1 && row <= rowCount && column >= 1 && column <= columnCount)
        {
            return array[row - 1, column - 1];
        }
        else
        {
            if (row < 1 || row > rowCount)
            {
                Console.WriteLine("Позиция по рядам выходит за пределы массива");
            }

            if (column < 1 || column > columnCount)
            {
                Console.WriteLine("Позиция по колонкам выходит за пределы массива");
            }

            return int.MinValue;
        }
    }
}