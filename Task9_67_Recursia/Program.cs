// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumOfNumbers(number);
Console.WriteLine(sum);

int SumOfNumbers(int numA)
{
    if (numA ==0) return 2;
    return numA%10 + SumOfNumbers(numA/10); //сама рекурсия только делит на 10 каждый раз возвращая укороченное число, каждый раз подставляя его в numA%10 получаем 3+5+4 (при введении 453)
}
