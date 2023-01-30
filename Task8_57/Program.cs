// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int matrixRows = 4;
int matrixColumns = 4;
int matrixMinValue = 1;
int matrixMaxValue = 10;

int[,] firstMatrix = CreateMatrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
PrintMatrix(firstMatrix);
Console.WriteLine(String.Empty);

int[] firstArray = ConvertMatrixInArray(firstMatrix);
PrintArray(firstArray);
Console.WriteLine(String.Empty);
Array.Sort(firstArray);                 // встроенный метод сортировки массива!!!!!!!!!!
PrintArray(firstArray);
Console.WriteLine(String.Empty);
dictionaryArray(firstArray);

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

int[] ConvertMatrixInArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix[i, j];
            index++;
        }
    }
    return array;
}

void dictionaryArray(int[] array)
{
    int count = 1;
    int element = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (element == array[i]) count++;
        else
        {
            Console.WriteLine($"{element} -> {count}");
            count = 1;
            element = array[i];
        }
    }
    Console.WriteLine($"{element} -> {count}");
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");      // выводим на печать массив в виде [1, 2, 3, 8, 9] где скобки впереди и сзади, и нет в конце запятой
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
        if (i < array.Length - 1) Console.Write($"{array[i]}" + ", ");      // выводим на печать массив в виде [1, 2, 3, 8, 9] где скобки впереди и сзади, и нет в конце запятой
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}