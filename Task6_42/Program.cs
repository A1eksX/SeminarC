// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string ConvertDecimalToBin(int num)
{
    string result = string.Empty; //string.Empty = так обозначают пустую строку
    while (num > 0)
    {
        result = num % 2 + result;   // такая запись разворачивает наш вывод строки т.е. 123 -> 321
        num = num / 2;
    }
    return result;
}

string res = ConvertDecimalToBin(49);
Console.WriteLine(res);

// способ с int

//Console.Write("Введите число для преобразования в двоичную систему счисления: ");
int number = Convert.ToInt32(Console.ReadLine());
int convertDecimalToBinary = ConvertDecimalToBinary(number);
Console.WriteLine(convertDecimalToBinary);
int ConvertDecimalToBinary(int num)
{
    int result = 0;
    int multiplyer = 1;
    while (num != 0)
    {
        result = result + num % 2 * multiplyer;
        num = num / 2;
        multiplyer *= 10; 
    }
    return result;
}