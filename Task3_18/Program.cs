// Задача 18: Напишите программу, которая по
// 1. заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти от 1 до 4");
string quarter = Console.ReadLine();


Console.WriteLine(Quarter(quarter));  // результат

string Quarter(string quart)
{
    if (quart == "1") return "x > 0, y > 0";
    if (quart == "2") return "x < 0, y > 0";
    if (quart == "3") return "x < 0, y < 0";
    if (quart == "4") return "x > 0, y < 0";
    return "Неверный номер четверти";
}
