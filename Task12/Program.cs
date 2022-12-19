// 12. Напишите программу, которая будет принимать на вход два числа 
// выводить, является ли первое число кратным второму. 
//Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите два числа ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Multiplicity(firstNumber, secondNumber) == 0 ? "Кратно" : $"не кратно, остаток {Multiplicity(firstNumber, secondNumber)}");

int Multiplicity(int first, int second)
{
    return first % second;
}






