// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt()
{
    Console.WriteLine("Введите число N:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Counter(int N)
{
    int NN = 0;
    for(int i = 1; i <= N; i++)
    {
        NN* = i;
    }
    return NN;
}
int number = ReadInt();
int coun = Counter(number);
Console.WriteLine(coun);