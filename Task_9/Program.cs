
int number = new Random().Next(10, 100);
Console.WriteLine($"Number = {number}");
int maxNum = FindMaxNumber (number);
Console.WriteLine($"Max = {maxNum}");
//int firstDigit = number / 10;
//int secondDigit = number % 10;
//Console.WriteLine($"Number 1 = {firstDigit}");
//Console.WriteLine($"Number 2 = {secondDigit}");
//if (firstDigit == secondDigit)
//    Console.WriteLine($"Max = {firstDigit}");
//else
//    Console.WriteLine($"Max = {secondDigit}");
//Console.WriteLine(firstDigit > secondDigit ? $"Max = {firstDigit}" : $"Max = {secondDigit}");

int FindMaxNumber (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}