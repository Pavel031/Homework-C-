// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 100 || n > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число! Попробуйте еще раз: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Вторая цифра числа: " + n / 10 % 10);