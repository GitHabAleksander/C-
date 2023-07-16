// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = 10;

void NaturChisla(int LastNumber)
{
    if(LastNumber <= 0) return;
    NaturChisla(LastNumber - 1);
    Console.Write((number - LastNumber + 1) + " ");
}
NaturChisla(number);