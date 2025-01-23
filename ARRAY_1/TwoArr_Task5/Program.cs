/*Задание 2. Работа в сессионных залах
Семинар 5. Двумерные массивы
Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и
т.д.
Пример
2 3 4 3
 4 3 4 1 => 2 + 3 + 5 = 10
 2 9 5 4
 int SumDiagonal (int [,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == j)
            {
                sum  += matrix[i, j];
            }
        }
    }
    return sum;
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

int [,] matrix =
{
    {1, 3, 4, 3, 4},
    {1, 10, 9, 10, 5},
    {6, 4, 9, 1, 7}
};
PrintMatrix(matrix);
System.Console.WriteLine(SumDiagonal(matrix));
 */

int SumDiagonalArray(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                      
            {
                sum += matrix[i,j];
            }
        }
    }
    return sum;
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
int matrix =
{
    {1, 3, 4, 3, 4},
    {1, 10, 9, 10, 5},
    {6, 4, 9, 1, 7} 
};
PrintMatrix(matrix);
System.Console.WriteLine(SumDiagonalArray(matrix));


/*
// Задание 2. Работа в сессионных залах
// Семинар 5. Двумерные массивы
// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

int SumDiagonal (int [,] matrix)
{
    int sum = 0;

    int diagonalLength = Math.Min(matrix.GetLength(0), matrix.GetLength(1));

    for (int i = 0; i < diagonalLength; i++)
    {        
        sum  += matrix[i, i];                   
    }
    return sum;
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

int [,] matrix =
{
    {1, 3},
    {1, 10,},
    {6, 4}
};
PrintMatrix(matrix);
System.Console.WriteLine(SumDiagonal(matrix));
*/
