/*int[] arr = new int[5];
arr[0] = 5;
arr[1] = 7;
arr[2] = 8;
arr[3] = 1;
arr[4] = 2;
System.Console.WriteLine(arr[0]);
System.Console.WriteLine(arr[1]);
System.Console.WriteLine(arr[2]);
System.Console.WriteLine(arr[3]);
System.Console.WriteLine(arr[4]);


int[] arr2 = new int[5] { 1, 3, 5, 8, 0 };
int[] arr3 = { 4, 8, 5, 7, 1 }
*/
int n =10;
int[] arr = new int[n];
int i =0;

while (i <arr.Length)
{
    arr[i] = i + 1;
   // Console.Write(Arr[i]);
   // Console.Write(" ");
    Console.Write($"{arr[i]} ");
    i = i + 1;
}