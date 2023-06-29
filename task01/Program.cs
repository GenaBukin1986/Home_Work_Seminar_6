/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

// Метод, который просит ввести М чисел у пользователя
int[] UserNumbers()
{
    int number = new Random().Next(1, 20);
    int[] array = new int[number];
    string str;
    str = number == 0 || number > 4 ? "чисел": number == 1 ? "число": "числа";
    Console.WriteLine($"Необходимо ввести {number} {str}");
    int c = number - 1;
    for (int i = 0; i < number; i++)
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine()!);
        array[i] = n;
        if (c - i == 0)
        {
        continue;
        }
        string strs;
        strs = c - i == 0 || c - i > 4 ? "чисел": c - i == 1 ? "число": "числа";
        Console.WriteLine($"Осталось ввести {c - i} {strs}");
    }
    Console.WriteLine();
    return array;
}

// Метод, который считает сколько положительных чисел ввел пользователь
void PositivNumber(int[] array)
{
    int number = 0;
    foreach (int item in array)
    {
        number += item > 0 ? 1 : 0;
    }
    string str;
    str = number == 0 || number > 4 ? "чисел": number == 1 ? "число": "числа";
    Console.WriteLine($"Вы ввели {number} положительных {str}");
}

Console.Clear();
int[] arr = UserNumbers();
Console.WriteLine(String.Join(" ", arr));
PositivNumber(arr);