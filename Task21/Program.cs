// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки А(хa,ya,za)");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки А(хb,yb,zb)");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());

Console.Write("Расстояние межу точками равно: " + Math.Round(Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za)), 2));

