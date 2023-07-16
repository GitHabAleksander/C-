// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 9
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите M:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int M = Convert.ToInt32(Console.ReadLine());

int Akkerman(int n, int m) // функция Аккермана
{
    if(n == 0) return m + 1;
    else
    if((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
    else
    return Akkerman(n - 1, Akkerman(n, m - 1));
}
Console.WriteLine(Akkerman(N, M));
