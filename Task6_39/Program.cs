// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] ArrayRandomNumber(int size, int min, int max)     //создаётся и заполняется массив
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
   for (int i = 0; i < array.Length; i++)
    {
        if (i <array.Length-1) Console.Write($"{array[i]}" + ", ");      // выводим на печать массив в виде [1, 2, 3, 8, 9] где скобки впереди и сзади, и нет в конце запятой
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

//Array.Reverse (array);

void ReverseArray (int [] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length -1 - i] = temp;
    }
}

void ReverseArrayVersion2 (int [] array)       // Вариант разворота массива с циклов while 
{  
        int index1 = 0;
        int index2 = array.Length -1;

        while (index1 < index2)
        {
            int obj = array[index1];
            array[index1] = array[index2];
            array[index2] = obj;
            index1++;
            index2--;
        }
}

int [] array = ArrayRandomNumber (5,1, 10);
PrintArray(array);
//ReverseArray(array);
// Array.Reverse (array);  // Встроенный метод реверса массива
//PrintArray(array);

ReverseArrayVersion2(array);
PrintArray(array);
