// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.


// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle (int num1, int num2, int num3)
{
    int sum1 = num1 + num2;
    int sum2 = num1 + num3;
    int sum3 = num2 + num3;

    return num3 < sum1 && num2 < sum2 && num1 < sum3; 
}

bool result = IsExistTriangle(number1, number2,number3);
Console.WriteLine( result ? "существует" : "Не существует");