// Задача 8: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Add number:");
string? numberString = Console.ReadLine();
int numberA = Convert.ToInt32(numberString);
for (int i = 1; i < numberA + 1; i++)
{
    if (i % 2 == 1)
    {
        
    }
    else
    {
    Console.Write(i);
    }
}
