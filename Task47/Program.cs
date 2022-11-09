// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] array = new Double[3, 4];

fillArray(array);
printArray(array);

void fillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((new Random().NextDouble() * 100), 1);
        }
    }
}


void printArray(double[,] arr)
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