// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2

const int ROWS = 3;
const int COLUMS = 4;

int[,] RandomMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix;
}
int ReturnValue(int[,] matrix)
{
    int Value = 0;
    Console.WriteLine("Введите строку:");
    int rowsi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбец:");
    int columsj = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j j < matrix.GetLength(1); j++)
        {
            if(i < matrix.GetLength(0) && j < matrix.GetLength(1))
            {
                if(rowsi == i && columsj == j);
                {
                    Value = matrix[i, j];
                    Console.Write(Value);
                }
            }
            else
            {
                Console.Write($"Такого числа в массиве нет");
            }
        }  
    }
    return Value; 
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] myMatrix = RandomMatrix(ROWS, COLUMS);
PrintMatrix(myMatrix);

int Value1 = ReturnValue(myMatrix);
Console.WriteLine(Value1);