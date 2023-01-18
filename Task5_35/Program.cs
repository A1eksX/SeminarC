// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Введите нижнее значение отрезка");
int lowLevel = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнее значение отрезка");
int highLevel = Convert.ToInt32(Console.ReadLine());

int[] Massive = CreateArray(5, -100, 100);
Console.WriteLine();
int element = CountElem(Massive, lowLevel, highLevel);

Console.Write($"Кол-во элементов массива ");
PrintArray(Massive);
Console.Write($" в диапазоне {lowLevel} - {highLevel} составляет {element}");


int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int CountElem(int[] array, int low, int high)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > low - 1 && array[i] < high + 1) count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}" + " ");
    }
    Console.Write("]");
}