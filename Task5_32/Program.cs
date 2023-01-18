
// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArray(int size, int min, int max)       // создаём и заполняем массив случайными числами
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void ReversArray(int[] array)           //т.к. массив передаётся в метод по ссылке, то создаём и наполняем массив, печатаем его, потом переворачиваем и сразу заного печатаем перевёрнутый
{                                                   // для этого используем метод void при разворачивании.
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

// int[] ReversArray(int[] array)               //возможно с методом int[]  тоже правильно но преподаватель сказал что с void лучше!!!!
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -array[i];
//     }
//     return array;
// }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}" + " ");
    }
}

int[] arr = CreateArray(4, -9, 9);
PrintArray(arr);
Console.WriteLine();
//int[] revArr = ReversArray(arr);
ReversArray(arr);
PrintArray(arr);


// а можно вызвать метод в методе как настроке ниже
//PrintArray(ReversArray(arr));