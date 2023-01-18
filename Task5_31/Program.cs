// Задача 31: 
// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и 
// положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

// int[] array = new int[4];
// int positSumm = PositiveSummArray(array);
// int negatSumm = NegativeSummArray(array);

// FillArray(array, -10, 10);
// PositiveSummArray(array);
// NegativeSummArray(array);
// PrintArray(array);

// Console.WriteLine();
// Console.WriteLine($"сумма положительных чисел = {positSumm}");
// Console.WriteLine($"сумма отрицательных чисел = {negatSumm}");



int[] CreateArrayRndInt(int size, int min, int max)     // создаём метод типа int, который будет создавать массив arr и возвращать его. В массиве будут использоваться параметры size, min, max
{
    int[] arr = new int[size];                  //внутри метода создаём массив типа int с параметром size (размер массива)
    var rnd = new Random();                     // 
    for (int i = 0; i < arr.Length; i++)        //заполняем массив случайными числами  строки 37--40
    {
        arr[i] = rnd.Next(min, max + 1);        // т.к. диапазон считывается как [min, max), т.е. максимально значение не входит в диапазон, то для того чтоб не заморачиваться с 
                                                // последним значением диапазона из задания, можно написать (max + 1) и вводить данные согласно заданию. Т.е. задано [-9,9] так и вводим [-9,9]
                                                // иначе пришлось бы вводить [-9, 10].
    }
    return arr;
}

void PrintArray(int[] arr)                      // создаём метод типа void. В массиве будет использоваться параметр int[] arr.
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i <arr.Length-1) Console.Write($"{arr[i]}" + ", ");      // выводим на печать массив в виде [1, 2, 3, 8, 9] где скобки впереди и сзади, и нет в конце запятой
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int PositiveSummElem(int[] arr)                     //создаём метод для подсчёта положительных элементов массива
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int NegativeSummElem(int[] arr)                     //создаём метод для подсчёта отрицательных элементов массива
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] SumPositiveNegative (int[] arr)           // этот метод объединяем в себе методы PositiveSummElem и NegativeSummElem, но т.к. надо возвращать 2 значения, то это надо делать через массив
{                                               // для этого создаём метод типа int[] и при возврате значения создаём массив куда запишутся 2 возвращаемых значения new int [] {sumPos, sumNeg}
    int sumPos = 0;                             // тогда метод int[] SumPositiveNegative будет возвращать значения {sumPos, sumNeg} 
    int sumNeg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPos += arr[i];
        if (arr[i] < 0) sumNeg += arr[i];
    }
    return new int [] {sumPos, sumNeg};
}


int[] array = CreateArrayRndInt(12, -9, 9);         //вызов метода создания массива типа int, где мы задаём наши параметры (size, min, max) ->> (12, -9, 9). 12 - кол-во элементов (-9, 9) диапазон чисел
PrintArray(array);                                  //вызов метод печати массива. так вызывается метод типа void

int positSumm = PositiveSummElem(array);            // создаём переменную для хранения суммы положительных элементов
int negatSumm = NegativeSummElem(array);            // создаём переменную для хранения суммы положительных элементов
// Console.WriteLine($"сумма положительных чисел = {positSumm}");
// Console.WriteLine($"сумма отрицательных чисел = {negatSumm}");

int[] sumPositiveSumNegative= SumPositiveNegative(array); // объединённый метод для подсчёта положительых и отрицательных элементов массива
Console.WriteLine($"сумма положительных чисел = {sumPositiveSumNegative [0]}");  // это вызов суммы положительных элементов из объединённого массива (стр 91)
Console.WriteLine($"сумма отрицательных чисел = {sumPositiveSumNegative [1]}");  // это вызов суммы отрицательных элементов из объединённого массива (стр 91)