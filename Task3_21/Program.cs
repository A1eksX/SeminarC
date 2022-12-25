// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А");
int xA = Convert.ToInt32(Console.ReadLine());
int yA = Convert.ToInt32(Console.ReadLine());
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Б");
int xB = Convert.ToInt32(Console.ReadLine());
int yB = Convert.ToInt32(Console.ReadLine());
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Range(xA, yA, zA, xB, yB, zB), 2, MidpointRounding.ToZero);   // -   округляем число до 2 знака и MidpointRounding.ToZero не округляем последний знак (показывает как есть)

Console.Write(distance);

double Range (int xA1, int yA1, int zA1, int xB1, int yB1, int zB1)
{
    double range = Math.Sqrt(Math.Pow((xA1 - xB1),2) + Math.Pow((yA1-yB1),2) + Math.Pow((zA1-zB1),2));
    return range;
}
