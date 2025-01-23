/*
// Выделяет память, заполняет матрицу
int[,] GetArray(int rows = 10, int cols = 10)
{
    int[,] matrix = new int[rows, cols];

    FillArray(matrix);

    return matrix;
}

// Перезаполняет/заполняет уже созданную матрицу
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j * 10;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write($"{matrix[i, j],-4}"); с выводом 4 знаков
            Console.Write($"{matrix[i, j]:d2}  "); // с выводом 2 знаков с ведущими нулями
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// создается matrix1, выделяется память, заполняется
int[,] matrix1 = GetArray(3, 4);
PrintMatrix(matrix1);

// перезаполняется matrix1
FillArray(matrix1);
PrintMatrix(matrix1);

// в matrix1 присваивается ссылка на другую выделенную память, с заполненными значениями
matrix1 = GetArray(3);
PrintMatrix(matrix1);

// создается matrix3, выделяется память, заполняется
int[,] matrix3 = GetArray();
PrintMatrix(matrix3);

// создается matrix4, выделяется память, заполняется
int[,] matrix4 = GetArray(cols:5);
PrintMatrix(matrix4);
*/

int[,] GetArray(int rows = 10, int cols = 10)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i * 10 + j;
        }
    }

    return matrix;
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j * 10;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write($"{matrix[i, j],-4}");
            Console.Write($"{matrix[i, j]:d2}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] matrix1 = GetArray(3, 4);
PrintMatrix(matrix1);

FillArray(matrix1);
PrintMatrix(matrix1);

matrix1 = GetArray(3);
PrintMatrix(matrix1);

int[,] matrix3 = GetArray();
PrintMatrix(matrix3);

int[,] matrix4 = GetArray(cols:5);
PrintMatrix(matrix4);

