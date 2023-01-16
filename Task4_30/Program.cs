// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]




// int number = new Random().Next(100, 1000);

//Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");

int[] array = new int[8];

// Console.WriteLine($"{Array(arr)}");
Array(array);

PrintArray(array);

void Array(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);  //Случайное число из отрезка 0 - 1
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


// int[] array = new int[8]; // 0,1,2,3,4,5,6,7

//             FillArray(array);
//             PrintArray(array);

//             void FillArray(int[] arr)
//             {
//                 Random rnd = new Random(); // тут создаём объект ........
//                 for (int i = 0; i < arr.Length; i++)
//                 {
//                     arr[i] = rnd.Next(0, 2);
//                 }
//             }

//             void PrintArray(int[] arr)
//             {
//                 for (int i = 0; i < arr.Length; i++)
//                 {
//                     Console.Write(arr[i] + " ");
//                 }
//             }
