// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


Console.WriteLine("Введите кол-во элементов массива");
int vollume = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение диапазона");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное значение диапазона");
int maximum = Convert.ToInt32(Console.ReadLine());

if (vollume > 0 && maximum > minimum)
{
    int[] array = CreateArray(vollume, minimum, maximum);

    PrintArray(array);
}
else if (vollume <= 0) Console.WriteLine("Количество элементов массива должно быть > 0");
else if (maximum <= minimum) Console.WriteLine("Максимальное количество элементов массива должно быть больше минимального");

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);  //Случайное число из отрезка min - max
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        else if (i > 0 && i < array.Length - 2) Console.Write($"{array[i]}, ");
        else if (i == array.Length - 1) Console.Write($"{array[array.Length - 1]}] ");
    }
}