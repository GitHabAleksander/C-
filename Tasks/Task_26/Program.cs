// Задача 26: Напишите программу, которая принимает на вход число
//  и выдаёт количество цифр в числе.
// // 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt()
{
    Console.WriteLine("Введите число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Counter(int a)
{
    int count = 0;
    while(a > 0)
    {
        a = a / 10;
        count++;
    }

    return count;
}
int number = ReadInt();
int coun = Counter(number);
Console.WriteLine(coun);
