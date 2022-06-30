/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом */

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
Task19(number);

void Task19 (string num)
{
    if (num[0] == num[4] && num[1] == num[3]) 
    {
        Console.WriteLine("Число " + num + " является палиндромом");
    }
    else if (num.Length > 5 || num.Length < 5) 
    {
        Console.WriteLine("Введено неверное число");
    }
    else Console.WriteLine("Число " + num + " не является палиндромом");
}