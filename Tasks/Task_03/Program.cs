// Задача 6: Напишите программу, которая на вход принимает число
//  и выдаёт, является ли число чётным 
//  (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Add number:");
string? numberString = Console.ReadLine();
int numberA = Convert.ToInt32(numberString);
if(numberA % 2 == 1)
{
    Console.Write("Нечетное");
}
else
{
    Console.Write("Четное");
}