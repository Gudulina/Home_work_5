/*
Задача 2: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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