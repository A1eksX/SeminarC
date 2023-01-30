// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите 1 число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число: ");
int numberB = Convert.ToInt32(Console.ReadLine());


int powerNum = PowerOfNumbers(numberA, numberB);
Console.WriteLine(powerNum);

int PowerOfNumbers(int numA, int numB)
{
    if (numB == 0) return 1;                        // когда numB станет равен 0, PowerOfNumbers станет равно 1 =>в конце  numA * 1
    return numA * PowerOfNumbers(numA, numB-1);     // numA будет умножаться на numA до тех пор, пока numB не станет равен 0 и тогда PowerOfNumbers вернёт 1 (return=1) 
}