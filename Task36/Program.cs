// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

void Sum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)            
    {
        sum += array[i];
    }
    Console.Write($"Сумма элементов на нечетных позициях равна: {sum}");
}
FillArray(array, 0, 100);        
PrintArray(array);
Sum(array);