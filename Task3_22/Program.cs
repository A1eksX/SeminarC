// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

TableSqrt(number);

void TableSqrt(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i,4} | {Math.Pow(i, 2),4}");
    }
}