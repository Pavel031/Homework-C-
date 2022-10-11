// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Какой день недели хотите узнать?: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 0 || n > 7)
{
    Console.WriteLine("У нас всего 7 дней недели");
    Console.Write("Какой день недели хотите узнать?: ");
    n = Convert.ToInt32(Console.ReadLine());
}

if (n >= 1 && n <= 5) Console.Write("Это будний день, иди работай");

if (n == 6 || n == 7) Console.Write("Это выходной, учись программировать");

/*Console.Write("Какой день недели хотите узнать?: ");
int n = Convert.ToInt32(Console.ReadLine());

switch (n)
{
    case 1:
        Console.Write("Это понедельник, иди работай");
        break;
    case 2:
        Console.Write("Это вторник, иди работай");
        break;
    case 3:
        Console.Write("Это среда, иди работай");
        break;
    case 4:
        Console.Write("Это четверг, иди работай");
        break;
    case 5:
        Console.Write("Это пятница, иди работай");
        break;
    case 6:
        Console.Write("Это суббота, учись программировать");
        break;
    case 7:
        Console.Write("Это воскресенье, учись программировать");
        break;
    default:
        Console.WriteLine("Что-то пошло не так. Введи номер дня недели от 1 до 7");
        Console.Write("Какой день недели хотите узнать?: ");
        n = Convert.ToInt32(Console.ReadLine());
        break;
}*/

