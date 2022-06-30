// Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7

Console.WriteLine("Введите трёхзначное число N");
string number = Console.ReadLine();
DopTask03(number);

void DopTask03 (string n)
{
    if (n.Length == 3)
    {
        if (Convert.ToString(n[0]) == Convert.ToString(4) || Convert.ToString(n[0]) == Convert.ToString(7)) Console.WriteLine("Среди цифр числа " + n + " есть 4 или 7");
        else if (Convert.ToString(n[1]) == Convert.ToString(4) ||Convert.ToString(n[1]) == Convert.ToString(7)) Console.WriteLine("Среди цифр числа " + n + " есть 4 или 7");
        else if (Convert.ToString(n[2]) == Convert.ToString(4) ||Convert.ToString(n[2]) == Convert.ToString(7)) Console.WriteLine("Среди цифр числа " + n + " есть 4 или 7");
        else Console.WriteLine("Среди цифр числа " + n + " нет цифр 4 или 7");
    }
    else Console.WriteLine("Введено неверное число");
}