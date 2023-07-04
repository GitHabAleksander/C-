// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму
//  цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt()
{
    Console.WriteLine("Введите число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int SumCounter(int a)
{
    int result = 0;
        while(a > 0)
    {
       result += a % 10;
       a = a / 10;
    }
    return result;
}
int a = ReadInt();
int coun = SumCounter(a);
Console.WriteLine(coun);
