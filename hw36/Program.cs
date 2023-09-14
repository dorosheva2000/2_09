/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(-100, 101);
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

int SummOfOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
}

Console.WriteLine("Please input array size!");
int[] arr = CreateArray(int.Parse(Console.ReadLine()!));
FillArray(arr);
PrintArray(arr);
Console.WriteLine($"Summ of elements on odd positins: {SummOfOddElements(arr)}");