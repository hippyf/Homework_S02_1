// Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.

Console.WriteLine("Введите трёхзначное число N");
int number = Convert.ToInt32(Console.ReadLine());
DopTask02(number);

void DopTask02 (int n)
{
    if (n >= 100 && n <= 999)
    {
        int sum = (n/100 + (n%100)/10 + n%10);
        if (sum%3 == 0) Console.WriteLine ("Сумма цифр числа " + number + " кратна трём");
        else Console.WriteLine ("Сумма цифр числа " + number + " не кратна трём");
    }
    else Console.WriteLine ("Введено неверное число");
}