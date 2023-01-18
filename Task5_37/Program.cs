// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите размер массива");
int vollume = Convert.ToInt32(Console.ReadLine());

int[] Mass = Massive(vollume, -10, 10);
PrintArray(Mass);
Console.WriteLine();

int[] NewMass = NewArray(Mass);    
PrintArray(NewMass);

int[] Massive(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

int[] NewArray(int[] array)               // нечётный массив
{
    int length = array.Length / 2;      // получаем длину нового массива
          
    if (array.Length % 2 != 0) length += 1;     // если старый массив нечётный, то новый массив увеличиваем на 1

    int[] newArray = new int[length];       // объявляем новый массив с номым кол-вом элементов
 
    for (int i = 0; i < length; i++)        //используя длину нового массива, заполняем его
    {
        newArray[i] = array[i] * array[array.Length - i - 1];
    }
    Console.WriteLine(array.Length/2);
    if (array.Length % 2 == 1) newArray[length - 1] = array[array.Length / 2 ];
    Console.WriteLine(array[array.Length / 2 ]);
    return newArray;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}" + " ");
    }
    Console.Write("]");
}
