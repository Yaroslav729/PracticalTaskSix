// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.Write("Введите значение точки b1: ");
double bOne = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение точки k1: ");
double KOne = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение точки b2: ");
double bToo = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение точки k2: ");
double kToo = int.Parse(Console.ReadLine()!);

    double x = (bToo- bOne) / (KOne - kToo);
    double y = (KOne*(bToo-bOne)) / (KOne-kToo)+bOne;




Console.Write($"({x}; {y})");