// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] arr = GetRandomArray(4);
PrintArray(arr);
Console.WriteLine("Разница между max и min: "+ FindResult(arr));

int FindResult(int[] array)
{
    int result = 0;
    int max = array[0];
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        result = max - min;
    }
    return result;
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
