// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] ArrayRndDoubleNumber(int size, int min, int max)     //создаётся и заполняется массив данными типа double
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;      //создаём переменную типа double, которая будет зажаваться нужным нам диапазоном min - max
        array[i] = Math.Round(num, 1);                          //округляем число double num до 1 знака после запятой
    }
    return array;
}

double Minimum (double [] array)                    //находим минимальное значение элементов массива
{
    double min = array[0];
    for (int i=0; i<array.Length; i++)
    {
        if (array[i] < min) min = array [i];
    }
    return min;
}

double Maximum (double [] array)                    //находим максимальное значение элементов массива
{
    double max = array[0];
    for (int i=0; i<array.Length; i++)
    {
        if (array[i] > max) max = array [i];
    }
    return max;
}

void PrintArrayDouble(double[] array)                   //печать массива вещественных чисел типа double
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}" + " ");
    }
    Console.Write("]");
}

double[] Array = ArrayRndDoubleNumber(5, -5, 5);

double MinNumber = Minimum(Array);
double MaxNumber = Maximum(Array);

double delta =  Math.Round(MaxNumber - MinNumber, 1);

Console.Write($"Разница между максимальным и минимальным элементом массива");
PrintArrayDouble(Array);
Console.WriteLine($" составляет {delta}");