// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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


double[] ResultSummColumn(int[,] matrix) //
{
    int size = matrix.GetLength(1);
    double[] arithmetic = new double[size];  //массив, среднеарифметического значения элементов в каждом столбце.
    double summ = 0; //масив, куда будет заноситься сумма элементов столбца

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summ += matrix[i,j] / matrix.GetLength(0);
        }
        arithmetic[j] = Math.Round(summ / matrix.GetLength(0)) ;
        summ = 0;
    }
    return arithmetic;
}

// double[] ResultSummColumn(int[,] matrix) //
// {
//     int size = matrix.GetLength(1);
//     double[] arithmetic = new double[size];  //массив, среднеарифметического значения элементов в каждом столбце.
//     double[] summ = new double[matrix.GetLength(1)]; //масив, куда будет заноситься сумма элементов столбца

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             summ[j] += matrix[i, j];
//         }
//         arithmetic[j] = Math.Round(summ[j] / matrix.GetLength(0), 1);
//     }
//     return arithmetic;
// }

void PrintMatrix(int[,] matrixX)
{
    for (int i = 0; i < matrixX.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrixX.GetLength(1); j++)
        {
            if (j < matrixX.GetLength(1) - 1) Console.Write($"{matrixX[i, j],3},  ");  // выводим на печать матриццу где скобки впереди и сзади, 
            else Console.Write($"{matrixX[i, j],3}");   //и нет в конце запятой
        }
        Console.WriteLine("]");
    }
}

void PrintArray(double[] array)    // выводим на печать массив в виде [1, 2, 3, 8, 9] где скобки впереди и сзади, и нет в конце запятой
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}" + ", ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[,] Matrix = Matrix2D(2, 2, -10, 10);
double[] Result = ResultSummColumn(Matrix);
PrintMatrix(Matrix);
Console.WriteLine();

Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArray(Result);
