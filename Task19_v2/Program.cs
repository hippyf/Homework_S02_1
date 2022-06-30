/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом -вариант 2 */

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
Task19_v2(number);

void Task19_v2 (int numb)
{
    if (numb >= 10000 && numb <= 99999)
    {
        if ((numb/10000 == numb%10) && ((numb/1000)%10 == (numb%100)/10))
        {
            Console.WriteLine("Число " + numb + " является палиндромом");
        }
        else Console.WriteLine("Число " + numb + " не является палиндромом");
    }
    else Console.WriteLine("Число введено неверно");
}