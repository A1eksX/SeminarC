// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] CreateMatrixSumIndex(int rows, int colums, int min, int max)
{                          // 0      1
    int[,] matrix = new int[rows, colums]; //0 - кол-во строк, 1 - кол-во столбцов

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

int[,] FindEvenIndex(int [,] matrixX)
{                          // 0      1
    for (int i = 0; i < matrixX.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrixX.GetLength(1); j+=2)
        {
            matrixX[i, j] *= matrixX[i, j];
        }
    }
    return matrixX;
}

void PrintMatrix(int[,] matrixX)
{
    for (int i = 0; i < matrixX.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrixX.GetLength(1); j++)
        {
            if (j < matrixX.GetLength(1) - 1) Console.Write($"{matrixX[i, j],2},");      // выводим на печать массив в виде [1, 2, 3, 8, 9] где скобки впереди и сзади, и нет в конце запятой
            else Console.Write($"{matrixX[i, j],2}");
        }
        Console.WriteLine("]");
    }
}

int[,] matrixSumInd = CreateMatrixSumIndex(3, 4, 1, 20);
PrintMatrix(matrixSumInd);
Console.WriteLine();
int[,] FindEven = FindEvenIndex(matrixSumInd);
PrintMatrix(FindEven);

