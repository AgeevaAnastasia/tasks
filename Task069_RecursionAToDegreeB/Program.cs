﻿// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.Clear();
int aUser = InputNumbers("Введите число: ");
int bUser = InputNumbers("Введите степень числа: ");



int GetDegree(int a, int b)
{
    if (b == 0) return 1;
    return GetDegree(a, b - 1) * a;
}

if (bUser >= 0) Console.WriteLine($"{aUser} в степени {bUser} равно {GetDegree(aUser, bUser)}");
else Console.WriteLine("Степень должна быть натуральна");


int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
