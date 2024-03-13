int num = new Random().Next(2, 10);
int[] array = new int[num];

for(int i = array.Length-1; i>= 0; i--)
{
    array[i] = new Random().Next(1, 99);
    Console.WriteLine(array[i]);
}

Console.WriteLine();

void PrintArray(int[] array2, int i)
{
    if(i == 0) return;
    PrintArray(array2, i-1);
    Console.WriteLine(array2[i-1]);
}

PrintArray(array, num);
