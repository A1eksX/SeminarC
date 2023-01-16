// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число ");
int oneDigital = Convert.ToInt32(Console.ReadLine());

if (oneDigital >0)  Console.WriteLine($"{oneDigital} -> {Summ(oneDigital)}");
else Console.WriteLine($"{oneDigital} -> {Summ(oneDigital)*-1}");


int Summ(int oneDigit)
{
    int summaDigit = 0;
    while (oneDigit != 0)
    {

        int digit = oneDigit % 10;

        summaDigit = summaDigit + digit;
        oneDigit = oneDigit / 10;
    }
    return summaDigit;
}