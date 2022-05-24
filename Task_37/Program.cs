Console.Write("Введите длину массива: ");
int nLength = int.Parse(Console.ReadLine());
int nLength2 = nLength / 2;
if (nLength % 2 != 0) nLength2 = (nLength / 2) + 1;
int[] rndNum = new int[nLength];
int[] multiply = new int[nLength2];
FillArray(rndNum);
PrintArray(rndNum);
Console.Write(" -> ");
Search(rndNum);
PrintArray(multiply);


void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] arr)
{
    string str = "[";

    for (int i = 0; i < arr.Length; i++)
    {
        str += $", {arr[i]}";
    }

    str = str.Remove(1, 2);
    str += "]";
    Console.Write($"{str}");
}

void Search(int[] a)
{
    int n = a.Length;
    for (int i = 0; i <= n / 2; i++)
    {
        multiply[i] = a[i] * a[n - 1 - i];
    }
    if (a.Length % 2 != 0) multiply[multiply.Length - 1] = rndNum[rndNum.Length / 2];
}
