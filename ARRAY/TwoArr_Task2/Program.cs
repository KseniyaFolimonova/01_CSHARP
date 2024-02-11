int[,] CreateArray(int rowCount, int columCount)
{
    int[,] array = new int[rowCount, columCount];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); i++)
        {
            array[i, j] = rnd.Next(1, 1000)
        }
    }
    return array;
}
int[,] array = CreateArray(2,4);
