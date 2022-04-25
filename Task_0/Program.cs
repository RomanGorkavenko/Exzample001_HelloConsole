// Напишите программу, которая на вход
//принимает число и выдаёт его квадрат (число
//умноженное на само себя).

Console.Write("Введите число -> ");
int num = int.Parse(Console.ReadLine());
int numResult = num * num;
Console.Write("Квадрат числа равен -> ");
Console.WriteLine(numResult);
Console.ReadKey();
