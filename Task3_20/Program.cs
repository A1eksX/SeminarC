// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21



// Math.Pow(2, 3);          -   Возведение 2 в 3 степень
// double d = Math.Sqrt(355);  - Корень числа 355

// double num = 5.099873456;
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero);       -   округляем число до 2 знака и MidpointRounding.ToZero не округляем последний знак (показывает как есть)
// Console.WriteLine(numRound);

Console.WriteLine("Введите координаты x1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y2");
int y2 = Convert.ToInt32(Console.ReadLine());

double dist = Math.Round(Range(x1, y1, x2, y2), 2, MidpointRounding.ToZero);   // -   округляем число до 2 знака и MidpointRounding.ToZero не округляем последний знак (показывает как есть)

Console.WriteLine(dist);

double Range (int xa, int ya, int xb, int yb)
{
    double range = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb-ya),2));
    return range;
}

