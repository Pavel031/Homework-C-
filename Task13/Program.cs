// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 100)
{
    Console.WriteLine("Третьей цифры тут нет! Попробуйте еще раз: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Третья цифра числа: " + n.ToString()[2]);