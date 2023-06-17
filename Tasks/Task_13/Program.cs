// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введи число:");
string? number = Console.ReadLine();
int numberA = Convert.ToInt32(number);
if((numberA / 100 > 0) && (numberA / 1000 == 0))
    {
        Console.WriteLine("Третье число");
        int numTh = (numberA % 10);
        Console.WriteLine(numTh);
    }   
    else if((numberA / 1000 > 0) && (numberA / 10000 == 0))
    {
        Console.WriteLine("Третье число");
        int numTh = (numberA % 100) / 10;
        Console.WriteLine(numTh); 
    }
    else if((numberA / 10000 > 0) && (numberA / 100000 == 0))
    {
        Console.WriteLine("Третье число");
        int numTh = (numberA % 1000) / 100;
        Console.WriteLine(numTh); 
    }
    else if((numberA / 100000 > 0) && (numberA / 1000000 == 0))
    {
        Console.WriteLine("Третье число");
        int numTh = (numberA % 10000) / 1000;
        Console.WriteLine(numTh); 
    }
else
{
    Console.WriteLine("Введите число больше двухзначного");
}





// if ((numberA / 100 > 0) && (numberA / 1000 == 0))
