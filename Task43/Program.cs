// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double x = 0;
double y = 0;

Console.Write("Введите первый коэффициент k1: ");
double koeff1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите первую константу b1: ");
double const1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второй коэффициент k2: ");
double koeff2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите вторую константу b2: ");
double const2 = Convert.ToDouble(Console.ReadLine());

while (koeff1 != koeff2 && const1 != const2)
{
x = (const2 - const1) / (koeff1 - koeff2);
y = (koeff1*(const2-const1))/(koeff1-koeff2)+const1;

Console.WriteLine($"Точка пересечения прямых имеет координаты ({x}, {y})");
break;
}
if ((koeff1 == koeff2) && (const1 == const2))
{
Console.WriteLine("Прямые совпадают");
}
else if (koeff1==koeff2)
{
Console.WriteLine("Прямые параллельны");
}