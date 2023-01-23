// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] EnterNumber(int size)  //создаём массив и заполняемый пользователем
{
    int[] massiveNum = new int[size];
    Console.WriteLine($"Введите число ");
    for (int i = 0; i < massiveNum.Length; i++)
    {
        int EnterNum = Convert.ToInt32(Console.ReadLine());
        massiveNum[i] = EnterNum;
    }
    return massiveNum;
}

int CheckNumber(int[] array)    // ищем в массиве числа > 0
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] array)    // выводим на печать массив в виде [1, 2, 3, 8, 9] где скобки впереди и сзади, и нет в конце запятой
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}" + ", ");      
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Укажите кол-во чисел (> 0), которое необходимо ввести");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 0) 
{
    int[] enterNum = EnterNumber(size);
    PrintArray(enterNum);
    int countNumber = CheckNumber(enterNum);
    Console.WriteLine($"Кол-во введённых чисел пользователем больших нуля {countNumber}");
}
else
Console.WriteLine("Кол-во чисел должно быть > 0");