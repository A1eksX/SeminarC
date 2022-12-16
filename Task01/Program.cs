// 1.Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.WriteLine("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int square = secondNumber * secondNumber;

if (firstNumber == square)
{
    Console.Write("Число является квадратом второго.");
}
else{
    Console.Write("Число не является квадратом второго");
}