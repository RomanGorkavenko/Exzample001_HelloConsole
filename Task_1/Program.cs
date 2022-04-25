// See https://aka.ms/new-console-template for more information

Console.Write("Введите число 1 -> ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2 -> ");
int num2 = int.Parse(Console.ReadLine());
bool result = num1 * num1 == num2;
Console.WriteLine(result ? "Да" : "Нет");
