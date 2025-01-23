

int[,] CreateMatrix(int rowCount, int columCount)
{
    int[,] matrix = new int[rowCount, columCount];
    Random rnd = new Random();

    // Заполнение матрицы случайными числами от 1 до 10
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }

    }
    return matrix;
}
// Вывод матрицы
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine(); // Переход на новую строку после каждой строки матрицы
    }
}
int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);