/* Напишите программу, которая задаёт массив произвольной длины, заполняет произвольными элементами и выводит их на экран.
Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.*/
int[] arr = new int[Length];

void newArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
        if (i < (array.Length-1)) Console.Write(", ");
    }
}
Console.Write("Введите длину ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max ");
int max = Convert.ToInt32(Console.ReadLine());
newArray(arr);
PrintArray(arr);
