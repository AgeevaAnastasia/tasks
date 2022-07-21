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

double GetDistance(int axc, int ayc, int bxc, int byc)
{
    return Math.Round(Math.Sqrt(Math.Pow((bxc - axc),2)+Math.Pow((byc - ayc),2)), 2, MidpointRounding.ToZero); // MidpoinRounding.ToZero - 
    //отбрасывает цифры после 2 после запятой, не округляя их (а иначе 5,1 получается)
}

double result = GetDistance(ax, ay, bx, by);
Console.WriteLine($"A({ax}, {ay}), B({bx}, {by}) -> {result}");
