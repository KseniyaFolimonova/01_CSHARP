

/*
Задание 3. Совместная работа
Семинар 5. Двумерные массивы
20 мин
Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива.
Пример
2 3 4 3
4 3 4 1 => [3 3 5]
2 9 5 4

 */

double[] GetMeansRows(int[,] matrix)
{
    double[] means = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double currentMean = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentMean += matrix[i, j];
        }
        currentMean /= matrix.GetLength(1);

        means[i] = currentMean;
    }

    return means;
}

// создается matrix1, выделяется память, заполняется
int[,] matrix = GetArray(3, 4);
PrintMatrix(matrix);

double[] means = GetMeansRows(matrix);

foreach (double number in means)
{
    Console.Write($"{number:f}  ");
}
Console.WriteLine();