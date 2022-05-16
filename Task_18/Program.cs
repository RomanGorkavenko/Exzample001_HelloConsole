// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти от 1 до 4: ");
int num = Convert.ToInt32(Console.ReadLine());

string range = Number(num);
Console.WriteLine(range);

string Number(int digit)
{
    
    if (digit == 1) return "x > 0 и y > 0";
    else if (digit == 2) return "x < 0 и y > 0";
    else if (digit == 3) return "x < 0 и y < 0";
    else if (digit == 4) return "x > 0 и y < 0";
    else return "Некорректный ввод!";
}