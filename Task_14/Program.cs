Console.WriteLine("Проверьте кратно ли число одновременно 7 и 23");
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
int first = num % 7;
int second = num % 23;
if (first == second)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

