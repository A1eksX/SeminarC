// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 99 && number < 999) Console.WriteLine($"Второе число равно {NumberTwo(number)}");
else Console.WriteLine("Вы ввели неверное число");


int NumberTwo(int numberTwo)
{
    numberTwo = numberTwo / 10;
    numberTwo = numberTwo % 10;
    return numberTwo;
}

