// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] arrayOrigin = CreateArrayRndInt(10, -3, 5);
int[] arrayCopy = CopyArray(arrayOrigin);
arrayCopy[0] = 30;
PrintArray(arrayOrigin);
PrintArray(arrayCopy);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] newArray = new int[size];
    var rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1);
    }
    return newArray;
}

int [] CopyArray (int [] newArray)
{
    int [] result = new int [newArray.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        result [i] = newArray[i];
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

