// Задача 34: 
// 1.Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2.Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] ArrayRandomNumber(int size, int min, int max)     //создаётся и заполняется массив
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int CountEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

void PrintArray(int [] array)
{
    Console.Write("[");
   for (int i = 0; i < array.Length; i++)
    {
        if (i <array.Length-1) Console.Write($"{array[i]}" + ", ");      // выводим на печать массив в виде [1, 2, 3, 8, 9] где скобки впереди и сзади, и нет в конце запятой
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int[] Array = ArrayRandomNumber(10, 100, 999);

int countNumber = CountEvenNumber (Array);

Console.Write($"Кол-во чётных чисел в массиве ");
PrintArray(Array);
Console.WriteLine($" равно {countNumber}");