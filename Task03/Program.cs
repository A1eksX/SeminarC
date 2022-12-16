// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.WriteLine("Введите число дня недели: ");
string numberDay = Console.ReadLine();

if (numberDay == "1") Console.WriteLine("Понедельник");

else if (numberDay == "2") Console.WriteLine("Вторник");

else if (numberDay == "3") Console.WriteLine("Среда");

else if (numberDay == "4") Console.WriteLine("Четверг");

else if (numberDay == "5") Console.WriteLine("Пятница");

else if (numberDay == "6") Console.WriteLine("Суббота");

else if (numberDay == "7") Console.WriteLine("Воскресенье");

else Console.WriteLine("Такого дня недели нет.");

