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

void Summa(int[] arr)
{
    int size = arr.Length;
    int temp = 0;
    for (int i = 1; i < size; i+=2)
    {
        temp += arr[i];
    }
    Console.WriteLine($"Сумма чисел на нечетных позициях = {temp}");
}

int[] arr1 = Array();
Print(arr1);
Summa(arr1);

int[] arr2 = Array();
Print(arr2);
Summa(arr2);
