/* Напишите программу, которая задаёт массив произвольной длины, заполняет произвольными элементами и выводит их на экран.
Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.*/


void newArray(int[]array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length-1)) Console.Write(", ");
    }
}
Console.Write("Введите длину ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[length];

newArray(arr, min, max);
PrintArray(arr);
