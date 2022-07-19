// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2d пространстве
// A(3,6) B(2,1) -> 5,09
// A(7,-5) B(1,-1) -> 7,21

Console.WriteLine("Введите координаты точки А ");
Console.Write("x: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
Console.Write("x: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int by = Convert.ToInt32(Console.ReadLine());

double Distance(int axc, int ayc, int bxc, int byc)
{
    double res = Math.Sqrt(Math.Pow((bxc - axc),2)+Math.Pow((byc - ayc),2));
    return (res);
}

double result = Distance(ax, ay, bx, by);
Console.WriteLine($"A({ax}, {ay}), B({bx}, {by}) -> {Math.Round(result, 2)}");
