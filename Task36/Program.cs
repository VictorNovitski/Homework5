﻿// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = GetRandomArray(4);
PrintArray(arr);
Console.WriteLine("Сумма нечетных позиций: "+ GetSumChet(arr));

int GetSumChet(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i]; 
    }
    return sum;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-99, 99);
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