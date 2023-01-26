// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

Console.WriteLine("Введите позиции элемента массива больше 0");
int rown = Convert.ToInt32(Console.ReadLine()) - 1;
int colum = Convert.ToInt32(Console.ReadLine()) - 1;

if (rown > 0 && colum > 0)
{
    int[,] MatrixX = Matrix2D(4, 5, -10, 10);
    PrintMatrix(MatrixX);
    Console.WriteLine();
    bool check = CheckPosition(MatrixX, rown, colum);
    Console.WriteLine(check ? $"значение введённого элемента матрицы {MatrixX[rown, colum]}" : $"{rown + 1},{colum + 1} -> такого элемента в массиве нет");
}
else
    Console.WriteLine("должно быть больше 0");

int[,] Matrix2D(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

bool CheckPosition(int[,] matrix, int row, int col)
{
    if (row < matrix.GetLength(0) && col < matrix.GetLength(1)) return true;
    return false;
}

void PrintMatrix(int[,] matrixX)
{
    for (int i = 0; i < matrixX.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrixX.GetLength(1); j++)
        {
            if (j < matrixX.GetLength(1) - 1) Console.Write($"{matrixX[i, j],3},  ");  // выводим на печать массив в виде [1, 2, 3, 8, 9] где скобки впереди и сзади, 
            else Console.Write($"{matrixX[i, j],3}");   //и нет в конце запятой
        }
        Console.WriteLine("]");
    }
}