// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine()); //num1

Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine()); //num2

int summElement = SummElement(m, n);

if (m > 0 & n > 0) Console.WriteLine($"{summElement}");
else Console.WriteLine("Введите числа m, n > 0");



int SummElement(int num1, int num2)
{
    if (num2 == num1) return num1;  // в этой строке методом тыка пришёл к выводу что должно быть -- return num2 или num1 --, но не понимаю как оно прибавляется к результату????

    if (num1 < num2) return num1 + SummElement(num1 + 1, num2);

    if (num2 < num1) return num2 + SummElement(num1, num2 + 1);

    return 0;
}