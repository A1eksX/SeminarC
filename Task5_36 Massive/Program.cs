// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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

int CountOddNumber(int[] array)             //считаем элементы массива расположенные на нечётных позициях
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 1 || i % 2 == 1) summ = summ + array[i];
   //     Console.WriteLine(summ);
    }
    return summ;
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

int[] Array = ArrayRandomNumber(10, -10, 10);

int countNumber = CountOddNumber (Array);

Console.Write($"Сумма нечётных чисел в массиве ");
PrintArray(Array);
Console.WriteLine($" равна {countNumber}");

