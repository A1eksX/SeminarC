// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифрой день недели:");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay > 0 && numberDay < 8) Console.WriteLine(Weekend(numberDay) ? "Да" : "Нет");
else Console.WriteLine("В неделе 7 дней, введите цифру от 1 до 7");

bool Weekend(int rest)
{
    return rest == 6 || rest == 7;
}
