// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите 3 координаты точки A через Enter: ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// int a2 = Convert.ToInt32(Console.ReadLine());
// int a3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 3 координаты точки B через Enter: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// int b2 = Convert.ToInt32(Console.ReadLine());
// int b3 = Convert.ToInt32(Console.ReadLine());


// double res = Math.Sqrt(Math.Pow((b1-a1),2)+Math.Pow((b2-a2),2)+Math.Pow((b3-a3),2));

// Console.WriteLine($"{res:0.00}");

// Сделать через метод!

Console.WriteLine("Введите координаты точки А ");
Console.Write("x: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
Console.Write("x: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int bz = Convert.ToInt32(Console.ReadLine());

double GetDistance3D(int axc, int ayc, int azc, int bxc, int byc, int bzc)
{
    return Math.Round(Math.Sqrt(Math.Pow((bxc - axc),2)+Math.Pow((byc - ayc),2)+Math.Pow((bzc - azc),2)), 2, MidpointRounding.ToZero); 
}

double result = GetDistance3D(ax, ay, az, bx, by, bz);
Console.WriteLine($"A ({ax}, {ay}, {az}); B ({bx}, {by}, {bz}) -> {result}");