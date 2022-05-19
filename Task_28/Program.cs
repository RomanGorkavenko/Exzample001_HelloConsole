// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите натуральное число: ");
int num = int.Parse(Console.ReadLine());

int GetSumNumbers(int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
        sum = sum * i;
    }
    return sum;
}

int sumResult = GetSumNumbers(num);
Console.WriteLine("Произведение чисел от 1 до {0} = {1}", num, sumResult);
