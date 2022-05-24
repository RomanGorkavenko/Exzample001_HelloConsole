
int[] rndNum = new int[123];
FillArray(rndNum);
PrintArray(rndNum);
Search(rndNum);

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-200, 200);
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
    Console.Write($"{str} -> ");
}

void Search(int[] a)
{
    int n = a.Length;
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (a[i] >= 10 && a[i] <= 99) 
        {
            count += 1;
        }
    }
    Console.Write(count);
}
