// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = GetRandomArray(4);
PrintArray(arr);
Console.WriteLine("Количество четных чисел: "+ GetSumChet(arr));

int GetSumChet(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i]% 2 == 0) sum++;
    }
    return sum;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100, 999);
    }
    return result;
}
void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + ", " );
    }
}
