// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");

int newDigit = NewDigit(number);

int NewDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int doub = firstDigit *10 + secondDigit;
    return doub;
}

Console.WriteLine(newDigit);