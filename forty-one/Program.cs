// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = new int [number];
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
}
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

int positive = 0;
void PositiveNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        positive ++;
    }
    Console.WriteLine($"Пользователь ввёл: {positive} числа больше 0");
}
PositiveNumbers(array);