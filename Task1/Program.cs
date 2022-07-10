/*
Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] Array()
{
    int size = 8;
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
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

void Number(int[] arr)
{
    int size = arr.Length;
    int temp = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0)
            temp += 1;
    }
    Console.WriteLine($"Количество чётных числе: {temp}");
}

int[] arr1 = Array();
Print(arr1);
Number(arr1);

int[] arr2 = Array();
Print(arr2);
Number(arr2);