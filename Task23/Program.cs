/* Напишите программу, которая принимает на вход число (N) и
 выдаёт таблицу кубов чисел от 1 до N. */

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Task23(number);

void Task23 (int num)
{
    if (num >= 1)
    {
        int i = 1;
        while (i <= num)
        {
            Console.Write(Math.Pow(i,3) + " ");
            i++;
        }
        Console.WriteLine();
    }
    else 
    {
        int i = 0;
        while (i >= num)
        {
            Console.Write(Math.Pow(i,3) + " ");
            i--;
        }
        Console.WriteLine();
    }
}