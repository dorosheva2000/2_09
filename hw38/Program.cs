/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().NextDouble() * (101 - 0) + 0;
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
} 

double MaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.WriteLine("Please input array size!");
double[] arr = CreateArray(int.Parse(Console.ReadLine()!));
FillArray(arr);
PrintArray(arr);
Console.WriteLine($"Difference between maximum and minimum array elements: {MaxElement(arr)} - {MinElement(arr)} = {MaxElement(arr) - MinElement(arr)}");