// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());

int SummMN(int FirstNumber, int LastNumber)
{
    if(LastNumber <= FirstNumber - 1) return 0;
    return SummMN(FirstNumber + LastNumber - 1);
}
Console.WriteLine(SummMN(M + N));
