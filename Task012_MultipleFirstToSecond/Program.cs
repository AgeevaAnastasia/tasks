// Напишите программу, которая принимает на вход 2 числа и выводит, является ли второе кратным первому. 
// Если не кратно, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16Б 4 -> кратно

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
int result = first % second;
if (result == 0) Console.WriteLine($"Число {first} кратно числу {second}");
else Console.WriteLine($"Число {first} не кратно числу {second}, остаток от деления равен {result}");

