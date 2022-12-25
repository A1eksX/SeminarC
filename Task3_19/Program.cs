// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int num = 0;

if ((number > 9999 && number < 100000) || (number > -100000 && number < -9999))
{
    if (number > 0) Console.WriteLine(Palindrome(number) == number ? "Да" : "Нет");

    else if (number < 0)  Console.WriteLine(SubPalindrome(number) == number ? "Да" : "Нет");
}
else Console.WriteLine("Вы ввели неверное число.");


int Palindrome(int numb)    // введёное число положительное

{
    for (int i = number; i > 0; i = (i / 10))
    {
        int ostatok = i % 10;
        num = num * 10 + ostatok;
    }
    return num;
}

int SubPalindrome(int numb)     // введёное число отрицательное

{
    for (int i = number; i < 0; i = (i / 10))
    {
        int ostatok = Math.Abs(i) % 10;
        num = num * 10 + ostatok;
    }
    return num * -1;
}

