// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (a > 0)
{
    result += a % 10;
    a = a / 10;
}
Console.Write($"Сумма цифр равна: {result}");