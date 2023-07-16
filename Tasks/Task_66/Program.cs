// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());

// int M = 1;
// int N = 15;


int SummMN(int FirstNumber, int LastNumber)
{
    if(LastNumber <= FirstNumber) return FirstNumber;
    return FirstNumber + SummMN(FirstNumber + 1, LastNumber);
}
int Sum = SummMN(M, N);
Console.WriteLine(Sum);
