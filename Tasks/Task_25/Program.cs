// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string massage)
{
    Console.Write(massage);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int Counter(int A, int exp)
{
    int B = 1;
    for (int i = 0; i < exp; i++)
    {
        B *= A;
    }
    return B;
}
bool ValidateExponent(int exp)
{
    if(exp < 0)
    {
        Console.WriteLine("Показатель не меньше нуля");
        return false;
    }
    return true;
}
int A = ReadInt("Введите основание числа: ");
int exp = ReadInt("Введите показатель: ");
if(ValidateExponent(exp))
{
    Console.WriteLine($"Число {A} в степени {exp} равен {Counter(A, exp)}");
}