void ZeroEventElements(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        System.Console.Write($"{e} ");
    }
}

int[] array = { 5, 7, 8, 4, 33, 6, 9, 2 };
ZeroEventElements(array);
PrintArray(array);


