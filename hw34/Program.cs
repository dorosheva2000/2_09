
/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
} 

int CountEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] % 2 == 0) count ++;
    }
    return count;
}

Console.WriteLine("Please input array size!");
int[] arr = CreateArray(int.Parse(Console.ReadLine()!));
FillArray(arr);
PrintArray(arr);
Console.WriteLine($"Number of even array elements: {CountEvenNumber(arr)}");