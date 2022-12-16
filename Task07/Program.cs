// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number <1000)
{
int endNumber = number % 10;    // остаток от деления на 10
Console.WriteLine("Последняя цифра числа = " + endNumber);
}
else
{
Console.WriteLine("Вы ввели невеное число.");
}