// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число больше 0 ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0) Cube(number);
else Console.WriteLine ("Введено некорректное число");

void Cube(int numb)
{
    for (int i = 1; i <= numb; i++)
    {
        Console.WriteLine($"{i,4} | {Math.Pow(i, 3),4}");
    }    
}