/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
int[] GetUserPoint()
{
    Console.WriteLine("Прямая задана уравнением y = k * x + b");
    Console.WriteLine();
    int[] arrs = new int[4];
    int j = 0;
    for (int i = 0; i < 2; i++)
    {
        string str;
        str = i == 0 ? "первой" : "второй";
        Console.Write($"Введите коофицент b {str} прямой: ");
        int x = int.Parse(Console.ReadLine()!);
        Console.Write($"Введите коофицент k {str} прямой: ");
        int y = int.Parse(Console.ReadLine()!);
        arrs[j] = x;
        j += 1;
        arrs[j] = y;
        j += 1;
    }
    return arrs;
}

// Метод, который возвращает точку пересечения двух прямых
void CheckLines(int[] points)
{
    if (points[1] - points[3] == 0) 
    {
    Console.WriteLine();
    Console.WriteLine($"Точки перечесечения прямых y = {points[1]} * x + {points[0]} и y = {points[3]} * x + {points[2]} нет, так как они параллельны");
    return ;
    }
    double x = Convert.ToDouble(points[2] - points[0]) / Convert.ToDouble(points[1] - points[3]);
    double y = x * points[1] + points[0];
    Console.WriteLine($"Точка перечесечения прямых y = {points[1]} * x + {points[0]} и y = {points[3]} * x + {points[2]} равна ({x}; {y})");
}

Console.Clear();
int[] array = GetUserPoint();
CheckLines(array);
