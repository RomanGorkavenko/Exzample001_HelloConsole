Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int[] rndNum = new int[5];
FillArray(rndNum);
PrintArray(rndNum);
string result = Search(rndNum);
Console.Write(result);



void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-10, 10);
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
    Console.Write($"{number}; массив {str} -> ");
}

string Search(int[] a)
{
    int n = a.Length;
    string res = "Нет";
    for (int i = 0; i < n; i++)
    {
        if (a[i] == number) 
        {
            res = "Да";
            
        }
    }
    return res;
}

