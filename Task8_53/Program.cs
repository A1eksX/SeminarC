// Задача 53: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{                          // 0      1
    int[,] matrix = new int[rows, colums]; //0 - кол-во строк, 1 - кол-во столбцов
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

int[,] ReversFirstAndLastLines(int[,] matrix)
{
    int firstLines = 0;
    int lastLines = matrix.GetLength(1) - 1;
    int temp;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[firstLines, j];
        matrix[firstLines, j] = matrix[lastLines, j];
        matrix[lastLines, j] = temp;
    }
    return matrix;
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

int rows = 4;
int columns = 4;
if (rows == columns)
{
    int[,] array2D = CreateMatrixRndInt(rows, columns, 1, 10);
    PrintMatrix(array2D);
    int[,] reversMatrixFirstLastLines = ReversFirstAndLastLines(array2D);
    Console.WriteLine(String.Empty);
    PrintMatrix(reversMatrixFirstLastLines);
}
else
    Console.WriteLine("кол-во строк должно быть равно кол-ву столбцов");