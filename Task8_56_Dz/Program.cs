// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] createMatrix = CreateMatrix(5, 4, 1, 10);
PrintMatrix(createMatrix);

int[] minSummElementString = MinSummElementString(createMatrix);
Console.WriteLine(String.Empty);
PrintArray(minSummElementString);

int searchMinElement = SearchMinElement(minSummElementString);

Console.WriteLine(String.Empty);
Console.WriteLine($"Наименьшая сумма элементов на {searchMinElement} строке");


int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return matrix;
}

int[] MinSummElementString(int[,] matrix)
{
    int[] minSummElementString = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            minSummElementString[i] += matrix[i, j];
        }
    }
    return minSummElementString;
}

int SearchMinElement(int[] array)
{
    int minElement = array[0];
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (minElement > array[i])
        {
            minElement = array[i];
            min = i+1;
        }
    }
    return min;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");      
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}" + ", ");      
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}