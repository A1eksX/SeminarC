// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А");
int oneDigital = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число степени В >= 0");
int twoDigital = Convert.ToInt32(Console.ReadLine());

if (twoDigital >= 0) Console.WriteLine ($"{oneDigital},{twoDigital} -> {Exponent (oneDigital, twoDigital)}");
else Console.WriteLine ("Вы ввели неверно число степени");

int Exponent (int oneDigit, int twoDigit)
{
    int exponentiation = 1;
    for (int i = 1; i <= twoDigit; i++)       
        {
            exponentiation = exponentiation * oneDigit;
        }
    return exponentiation;
}
