// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения координат 1 прямой x, y");
int b11 = Convert.ToInt32(Console.ReadLine());
int k11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения координат 2 прямой x, y");
int b21 = Convert.ToInt32(Console.ReadLine());
int k21 = Convert.ToInt32(Console.ReadLine());

double intersectionPointX = intersectionX (k11, b11, k21, b21);
double intersectionPointY = intersectionY (k11, b11);

Console.Write($"Координаты точки пересечения прямых [{intersectionPointX}, {intersectionPointY}]");

double intersectionX (double k1, double b1, double k2, double b2)    //расчёт X
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double intersectionY (double k1, double b1)    //расчёт Y
{
    double y = k1 * intersectionPointX + b1;
    return y;
}