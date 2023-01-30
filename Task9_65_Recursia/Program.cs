// Задача 65: 
// Задайте значения M и N. 
// Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M ");
int m = Convert.ToInt32(Console.ReadLine());

DiapasonNumber(n, m);

void DiapasonNumber(int numN, int numM)
{
    if (numN < numM)
    {
        Console.Write($"{numN} ");
        DiapasonNumber(numN + 1, numM);
    }

    if (numN > numM)
    {
        Console.Write($"{numM} ");
        DiapasonNumber(numN - 1, numM);
    }

    if (numM == numN) Console.Write($"{numM} ");
}
