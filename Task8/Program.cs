﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число, пожалуйста: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= n; i += 2)
    Console.Write(i + ", ");