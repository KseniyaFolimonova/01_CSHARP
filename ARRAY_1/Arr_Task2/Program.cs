//int n = 10;
int[] arr = { 2, 5, 7, 8, 10, 12, 3, 0, 48, 97 };
int i = 0;

while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
       
    }
    i = i + 1;
}
