// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] CreateMatrixSumIndex(int rows, int colums, int min, int max) // создаём и заполняем массив случайными вещественными числами
{
    double[,] rndDoubleMatrix = new double[rows, colums];
    var rnd = new Random();
    for (int i = 0; i < rndDoubleMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < rndDoubleMatrix.GetLength(1); j++)
        {
            rndDoubleMatrix[i, j] = Math.Round((rnd.Next(min, max) + rnd.NextDouble()), 1);
        }
    }
    return rndDoubleMatrix;
}

void PrintMatrix(double[,] matrixX)
{
    for (int i = 0; i < matrixX.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrixX.GetLength(1); j++)
        {
            if (j < matrixX.GetLength(1) - 1) Console.Write($"{matrixX[i, j], 5},  ");      // выводим на печать массив в виде [1, 2, 3, 8, 9] где скобки впереди и сзади, и нет в конце запятой
            else Console.Write($"{matrixX[i, j],5}");
        }
        Console.WriteLine("]");
    }
}

double[,] createMatrix = CreateMatrixSumIndex(3, 4, -10, 10);
PrintMatrix(createMatrix);
