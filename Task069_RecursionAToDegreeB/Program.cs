// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.Clear();
int aUser = InputNumbers("Введите число: ");
int bUser = InputNumbers("Введите степень числа: ");

int sum = 1;
Console.Write($"{aUser} в степени {bUser} равно ");
Console.Write(GetDegree(aUser, bUser, sum));
Console.WriteLine();

int GetDegree(int a, int b, int sum)
{
    if (b == 0) return sum;
    sum = sum * a;
    return GetDegree(a, b - 1, sum);
}





int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
