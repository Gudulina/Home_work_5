/*
Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] Array()
{
    int size = 5;
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(10, 100);
    }
    return arr;
}

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int Max(int[] arr)
{
    int index = 0;
    int max = arr[index];
    for (index = 1; index < arr.Length; index++)
    {
        if (arr[index] > max)
            max = arr[index];
    }
    return max;
}

int Min(int[] arr)
{
    int index = 0;
    int min = arr[index];
    for (index = 1; index < arr.Length; index++)
    {
        if (arr[index] < min)
            min = arr[index];
    }
    return min;
}

int[] arr1 = Array();
Print(arr1);
Max(arr1);
Console.WriteLine ($"Разница между {Max (arr1)} и {Min (arr1)} = {Max (arr1) - Min (arr1)}");

int[] arr2 = Array();
Print(arr2);
Min(arr2);
Console.WriteLine ($"Разница между {Max (arr2)} и {Min (arr2)} = {Max (arr2) - Min (arr2)}");
