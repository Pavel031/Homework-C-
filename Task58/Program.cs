// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrixA = new Int32[2, 2];
int[,] matrixB = new Int32[2, 2];
int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

fillArray(matrixA, 1, 10);
fillArray(matrixB, 1, 10);
printArray(matrixA);
Console.WriteLine();
printArray(matrixB);
Console.WriteLine();
printArray(multiplication(matrixA, matrixB));

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

        Console.WriteLine(" ");
    }
}

    int[,] multiplication(int[,] matrixA, int[,] matrixB)
    {       
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return matrixC;
    }

