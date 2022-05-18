
// Метод. Если метод что-то возвращает, то обязательно указываем тип данных значение которого мы ожидаем
string Method4(int count, string text) 
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// Вызов метода (аргументы по порядку)
string res = Method4(10, "z");
Console.WriteLine(res);
