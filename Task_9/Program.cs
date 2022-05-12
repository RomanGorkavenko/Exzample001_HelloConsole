
int number = new Random().Next(10, 100);
Console.WriteLine($"Number = {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
Console.WriteLine($"Number 1 = {firstDigit}");
Console.WriteLine($"Number 2 = {secondDigit}");
//if (firstDigit == secondDigit)
//    Console.WriteLine($"Max = {firstDigit}");
//else
//    Console.WriteLine($"Max = {secondDigit}");
Console.WriteLine(firstDigit > secondDigit ? $"Max = {firstDigit}" : $"Max = {secondDigit}");
