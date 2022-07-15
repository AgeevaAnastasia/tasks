// Напишите программу, которая проверяет, является ли одно число (первое или второе) квадратом второго (или первого, соотвтетсвенно)
// 5,25 -> да
// -4,16 -> да
// 25,5 -> да
// 8,0 -> нет

Console.Clear();
Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Square(a, b);

if (result == 1) Console.WriteLine($"{a}, {b} -> Да");
else Console.WriteLine($"{a}, {b} -> Нет");

int Square(int num1, int num2)
{
    if (a == b*b || b  == a*a) return 1;
    else return 0;
}