// 12. Напишите программу, которая будет принимать на вход два числа 
// выводить, является ли первое число кратным второму. 
//Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Введите первое целое число ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе целое число ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int result = firstNumber % secondNumber;

// if (result == 0) 
// {
//     Console.WriteLine("Кратно");
// }
// else 
// {
//     Console.WriteLine($"не кратно, остаток {result}");
// }

Console.WriteLine("Введите первое целое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int res = Multiplicity(firstNumber, secondNumber);

Console.WriteLine("Введите второе целое число ");


int Multiplicity(int first, int second)
{
    return first % second;
}



int res = Multiplicity(numberOne, numberTwo);
//Console.WriteLine(res == 0 ? "Кратно" : $"не кратно, остаток от деления {res}");
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine($"Не кратно, остаток {div}");
// }






