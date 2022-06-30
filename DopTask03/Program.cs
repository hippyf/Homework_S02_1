// Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7

Console.WriteLine("Введите трёхзначное число N");
int number = Convert.ToInt32(Console.ReadLine());
DopTask03(number);

void DopTask03 (int n)
{
    if (n >= 100 && n <= 999)
    {
        int number1 = n/100;
        int number2 = (n%100)/10;
        int number3 = n%10;
        if (number1 == 4 || number1 == 7 || number2 == 4 || number2 == 7 || number3 == 4 || number3 == 7)
        {
            Console.WriteLine("Среди цифр числа " + n + " есть 4 или 7");
        }
        else Console.WriteLine("Среди цифр числа " + n + " нет 4 или 7");
    }
    else Console.WriteLine("Введено неверное число");
}