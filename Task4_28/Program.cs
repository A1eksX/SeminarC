// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
//int number1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Произведение чисел от 1 до {number} = {SumNumbers(number)}");

int SumNumbers (int num)
{
    int sum = 1;
    for (int i =1; i<= num; i++)
    {
        checked     // эта команда предназначена для проверка на переполнение
                    // в итоге напишет ... Arithmetic operation resulted in an ->> "OVERFLOW".
        {
        //    sum *= sum + i;   строкой ниже тоже самое
        sum *= i;
        }

    }
    return sum;
}