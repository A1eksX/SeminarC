// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int rows = 2;
int columns = 3;
int rowsSecond = 3;
int columnsSecond = 2;
int min = 1;
int max = 10;

int[,] array2DSecond = CreateMatrix(rowsSecond, columnsSecond, min, max);
int[,] array2D = CreateMatrix(rows, columns, min, max);

Console.WriteLine($"Первая матрица: ");
PrintMatrix(array2D);
Console.WriteLine(String.Empty);

Console.WriteLine($"Вторая матрица: ");
PrintMatrix(array2DSecond);
Console.WriteLine(String.Empty);


if (columns == rowsSecond) 
{
    int[,] muliplicationMatrix = MuliplicationMatrix(array2D, array2DSecond);
    Console.WriteLine("Результирующая матрица");
    PrintMatrix(muliplicationMatrix);
}
else Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы");

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

int[,] MuliplicationMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] newMatrix = new int[matrixFirst.GetLength(1), matrixSecond.GetLength(0)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)  //3       строка
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)  //3   столбец
        {
            newMatrix[i, j] = matrixSecond[i, j - j] * matrixFirst[i - i, j] + matrixSecond[i, i - i + 1] * matrixFirst[i - i + 1, j];
        }
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