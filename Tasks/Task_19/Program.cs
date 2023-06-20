// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введи число:");
string? number = Console.ReadLine();
int numberA = Convert.ToInt32(number);
int num1 = (numberA % 100000) / 10000; 
int num2 = (numberA % 10000) / 1000; 
int num4 = (numberA % 100) / 10; 
int num5 = (numberA % 10); 
if((numberA / 10000 > 0) && (numberA / 100000 == 0))
{  
    if((num1 == num5) && (num2 == num4))
    {
        Console.WriteLine("Число является палиандром");
    }
    else if((num1 != num5) | (num2 != num4))
    {
        Console.WriteLine("Число не является палиандром");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}
