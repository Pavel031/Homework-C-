// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите первое число: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнее число: ");
int finish = Convert.ToInt32(Console.ReadLine());

Numbers(start, finish, 0);


void Numbers(int n, int m, int sum) {

    if (n > m) 
    {
        Console.WriteLine($"Сумма элементов равна: {sum}"); 
        return;
    }
    sum += (n ++);
    Numbers(n, m, sum);
}
