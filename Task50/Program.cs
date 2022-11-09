// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

Console.WriteLine("Введите позиции элемента в двумерном массиве: ");

int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new Int32[5, 5];

fillArray(array, -10, 10);
printArray(array);
Console.WriteLine();
foundElement(array, row, column);

void fillArray(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}

void foundElement(int[,] arr, int row, int column)
{
    if (row > arr.GetLength(0) - 1 || column > arr.GetLength(1) - 1)
    {
        Console.WriteLine("нет такого элемента");
    }
    else
    {
        Console.WriteLine($"Наэтой позиции находится элемент {arr[row, column]}");
    }
}

void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

