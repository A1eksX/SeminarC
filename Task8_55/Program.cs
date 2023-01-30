// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] ReversRowsToColumns(int[,] matrix)   //чтобы в нашем массиве не трогать 1 элемент [0,0] и последний элемент, в 1 цикле от длины строки отняли -1 (matrix.GetLength(0) - 1)
{                                                       //а во 2 цикле написали int j = i + 1. Т.о. 1 и 9 не будет затрагиваться в массиве
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)                                           // 1 2 3 2
    {                                                                                           // 4 5 6 5
        for (int j = i + 1; j < matrix.GetLength(1); j++)                                       // 7 8 8 4
        {                                                                                       // 7 4 1 9
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
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
    int[,] matrixRndInt = CreateMatrixRndInt(rows, columns, 1, 10);
    PrintMatrix(matrixRndInt);
    int[,] matrixReverceRowsToColums = ReversRowsToColumns(matrixRndInt);
    Console.WriteLine(String.Empty);
    PrintMatrix(matrixReverceRowsToColums);
}
else
    Console.WriteLine("кол-во строк должно быть равно кол-ву столбцов");