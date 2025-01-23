int[,] CreateMatrix(int rowCount, int colomsCount) // создали новый двумерный массив  и вернули его, вез печати
{
    int[,] matrix = new int[rowCount, colomsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(0, 101);
    }
    return matrix;
}
void PrintMatrix(int[,] matrix) //вывод двумерного массива на печать
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4);
PrintMatrix(matrix);

foreach (int elem in matrix)
{
    bool ElemIsInteresting = IsInretesting(elem);
    if (ElemIsInteresting)
    {
        System.Console.WriteLine(elem);
    }
}

bool IsInretesting(int digit)
{
    int SumOfDigits = GetSumOfDigits(digit);
    return SumOfDigits % 2 == 0;
      
}

int GetSumOfDigits(int value) // [] не нужны, т.к. выводит переменную а не массив
{
    int sum = 0;
    while (value != 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}