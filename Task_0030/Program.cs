// Напишите функцию, которая принимает
// на вход строку текста и печатает ее
// на экран в рамочке из символов +, - и |.
// Для красоты текст должен отделяться от рамки слева
// и справа пробелом.

// +-------------+
// | Hello world |
// +-------------+

Console.WriteLine("Ведите текст, чтобы напечатать его в рамке:");
string str = Console.ReadLine();

void WriteTextInAFrame(string text)
{
    string strUpDown = "+";
    string strCentre = "| " + text + " |";
    for (int i = 0; i < text.Length + 2; i++)
    {
        strUpDown += '-';
    }
    strUpDown += '+';
    Console.WriteLine(strUpDown);
    Console.WriteLine(strCentre);
    Console.WriteLine(strUpDown);
}

WriteTextInAFrame(str);

