// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

Console.Write("Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] array = new double[length];        // Задали массив из n элементов

void FillArray(double[] arr, int from, int to)     // Функция задает массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
}

void PrintArray(double[] array)          // Функция печатает массив
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]}");
}

double Diff(double[] array)
{
    double result = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
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
FillArray(array, 0, 100);        
PrintArray(array);
Console.Write($"Разница между максимальным и минимальным элементами равна: {Diff(array)}");