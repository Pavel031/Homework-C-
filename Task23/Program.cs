// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 1; i <= n; i++)
{
result = (int)Math.Pow(i, 3);
Console.Write(result + " ");
}