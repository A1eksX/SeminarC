// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine($"Задайте число");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(6, 0, 10);
//PrintArray(arr);
bool verification = VerificationNumber(arr, number);

if (verification == true) 
{
    Console.Write($"Число {number} есть в массиве ->") ;   //выводим на экран, если метод verifiication вернул true. Булевый метод нельзя вставить в " "
    PrintArray(arr);
}
else 
{
    Console.Write($"Числа {number} нет в массиве ->");                         // иначе НЕТ
    PrintArray(arr);
}

int[] CreateArray(int size, int min, int max) //создали и заполнили массив случайными числами
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

bool VerificationNumber(int[] array, int num)   //  массив на наличие заданного числа number
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)                // проверяем в цикле массив на наличие заданного числа number если есть, возвращаем true, если нет - false
        return true;
    }
    return false;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}" + ", ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}




















// bool IsExistNum(int[] arr, int num)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == num)
//             return true;
//     }
//     return false;
// }

// Console.Write("Введите число, которое хотите найти в массиве: ");
// int number = Convert.ToInt32(Console.ReadLine());
// bool isExistNum = IsExistNum(array, number);
// if (isExistNum)
// {
//     Console.Write($"Число {number} есть в массиве - ");
//     PrintArray(array);
// }
// else
// {
//     Console.Write($"Числа {number} нет в массиве - ");
//     PrintArray(array);
// }
