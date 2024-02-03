int n = 5;
int[] arr = { 8, 0, 45, 28, 63 };
int i = 0;
int max = arr[0];

while (i < n)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i +1;
}
System.Console.WriteLine(max);