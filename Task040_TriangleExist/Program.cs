// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();
int a = GetUserInput();
int b = GetUserInput();
int c = GetUserInput();

Console.Clear();
if (IsTriangle(a, b, c) == true) Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} существует");
else Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} не может существовать");



int GetUserInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool IsTriangle(int x, int y, int z)
{
    if (x + y > z && x + z > y && y + z > x) return true;
    else return false;
}

