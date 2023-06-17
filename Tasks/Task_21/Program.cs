// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Координата X1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата Z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координата X2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата Z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double XX = Math.Pow(x1 - x2, 2);
double YY = Math.Pow(y1 - y2, 2);
double ZZ = Math.Pow(z1 - z2, 2);
double result = Math.Sqrt(XX + YY + ZZ);
Console.WriteLine(result);