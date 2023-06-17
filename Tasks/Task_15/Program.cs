// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи число:");
string? number = Console.ReadLine();
int numDay = Convert.ToInt32(number);
if (numDay < 8)
{
    if(numDay < 5)
    {
        Console.Write(" Работаем!");
    }
    else
    {
        Console.Write(" Выходной!");
    }
}
else
{
    Console.WriteLine("Такого дня нет");
}