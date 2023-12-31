﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.

// Ввод числа с экрана
int Prompt(string massage)
{
    System.Console.Write(massage); // Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); // приводим к числу
    return result; // возвращаем результат
}

// Метод получения случайных значений массива
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; // объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);// заполняем случайным диапазоном SatrArr до EndArr
    
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");// вывод значения массива 
    }
    System.Console.Write($"{array[array.Length - 1]}");// вывод значения массива
    System.Console.WriteLine("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);//заполнение массива случайными числами
PrintArray(array);// вывод массива