// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int x1 = ReadInt("Введите X точки А: ");
int y1 = ReadInt("Введите Y точки А: ");
int z1 = ReadInt("Введите Z точки А: ");
int x2 = ReadInt("Введите X точки В: ");
int y2 = ReadInt("Введите Y точки В: ");
int z2 = ReadInt("Введите Z точки В: ");

int lenghX = x1 - x2;
int lenghY = y1 - y2;
int lenghZ = z1 - z2;

double distance = Math.Sqrt(lenghX*lenghX + lenghY*lenghY + lenghZ*lenghZ);
Console.Write($"{distance} - расстояние между точками в 3D пространстве.");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}