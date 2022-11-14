// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array = new Int32[2, 2, 2];

fillArray(array);
printArray(array);

void fillArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                int num = new Random().Next(10, 100);
                if(num != arr[i, j, k]){
                arr[i, j, k] = num;
                } 
            }
        }
    }
}

void printArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           for (int k = 0; k < arr.GetLength(2); k++)
           {
            Console.Write(arr[i, j, k] + "  (" + i + j + k + ") ");
           }
        }
        Console.WriteLine();
    }
}