// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = new Int32[5, 4];

fillArray(array, 0, 10);
printArray(array);
SumElements(array);

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

void SumElements(int[,] arr)
{
    int sum = 0;
    int minSum = 0;
    int row = 0;
    
    for (int i = 0 ; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if(i == 0)
        {
            minSum = sum;
        }
         
        if(minSum > sum) 
        {
            Console.WriteLine($"");
            minSum = sum;
            row = i;
        }
        sum = 0;
    }
    Console.Write($"строка с наименьшей суммой элементов: {row + 1}");
}

