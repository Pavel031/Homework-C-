// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(Akkerman(m, n));

int Akkerman(int a, int b) {

    if(a == 0) {
        return b + 1;
    }
    if(a > 0 && b == 0) {
        return Akkerman(a - 1, 1);
    }
    if(a > 0 && b > 0) {
       return Akkerman(a - 1, Akkerman(a, b - 1));
    }
    return Akkerman(a, b);
}