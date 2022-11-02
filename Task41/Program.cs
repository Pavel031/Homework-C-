// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.Write("Введите количество чисел ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new Int32[length];        // Задали массив из length элементов

void FillArray(int[] arr)     // Функция задает массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
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

    int count = 0;

void CountNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)            
    {
        if (array[i] > 0) count++;
    }
    
}
FillArray(array);        
PrintArray(array);
CountNumbers(array);
Console.Write($"Количество положительных чисел: {count}");