int number = new Random().Next(100, 1000);
Console.WriteLine($"Number = {number}");
string composNum = СompositeNumber (number);
Console.WriteLine($"Num {composNum}");

string СompositeNumber (int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return $"{firstDigit}{thirdDigit}";
}