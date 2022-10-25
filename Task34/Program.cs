// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new Int32[length];        // Задали массив из n элементов

void FillArray(int[] arr, int from, int to)     // Функция задает массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
}

void PrintArray(int[] array)          // Функция печатает массив
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]}");
}

void quantity(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
        sum++;
        }
    }
    Console.Write($"Количество четных элементов: {sum}");
}
FillArray(array, 100, 999);        
PrintArray(array);
quantity(array);