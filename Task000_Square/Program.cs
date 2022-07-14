// Task00
//Прорамма на вход получает число N и на выходе выдает квадрат этого числа. 
// N=2 -> 4     N=-4->16 и так далее

Console.Clear();
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine($"Квадрат числа {number} равен {result}");