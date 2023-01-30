// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[] CheckIndexMinNumber(int[,] matrix)
{
    int min = matrix[0, 0];
    int indexRows = 0;
    int indexColumns = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexRows = i;
                indexColumns = j;
            }
        }
    }
    return new int[] { indexRows, indexColumns, min };
}

int[,] NewMatrix(int[,] matrix, int deleteRows, int deleteColumns)
{
    int a = 0;
    int b = 0;
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if(a == deleteRows) a++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (b == deleteColumns) b++;
            newMatrix[i,j] = matrix [a,b];
            b++;
        }
        b = 0;
        a++;
    }
    return newMatrix;
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

void PrintArray(int[] MinRowsColumns)
{
    for (int i = 0; i < MinRowsColumns.Length; i++)
    {
        Console.Write(MinRowsColumns[i] + " ");
    }
}


int rows = 4;
int columns = 4;
int min = 1;
int max = 10;

int[,] array2D = CreateMatrix(rows, columns, min, max);
PrintMatrix(array2D);
Console.WriteLine(String.Empty);
int[] CheckMinIndex = CheckIndexMinNumber(array2D);
PrintArray(CheckMinIndex);


int[,] CreateNewMatrix = NewMatrix(array2D, CheckMinIndex[0], CheckMinIndex[1]);
Console.WriteLine(String.Empty);
PrintMatrix(CreateNewMatrix);

// к 56 задаче https://studwork.org/spravochnik/matematika/matricy/umnojenie-matric