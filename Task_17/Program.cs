Console.Write("Введите координату X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("Диапазон находится в 1 четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Диапазон находится в 2 четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Диапазон находится в 3 четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Диапазон находится в 4 четверти");
}
else
{
    Console.WriteLine("Значение не должно равняться 0");
}