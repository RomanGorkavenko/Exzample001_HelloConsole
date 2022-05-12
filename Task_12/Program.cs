Console.Write("Число1 ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Число2 ");
int num2 = int.Parse(Console.ReadLine());
int num = num1 % num2;
if (num == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {num}");
}