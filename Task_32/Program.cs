int[] rndNum = new int[4];
FillArray(rndNum);
PrintArray(rndNum);
Console.Write(" -> ");
FillArrayNegative(rndNum);
PrintArray(rndNum);

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-9, 10);
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

void FillArrayNegative(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = a[i] * -1;
    }
}
