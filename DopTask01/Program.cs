/* . Рассчитать значение y при заданном x 
по формуле y = (sin^2 x) при x > 0 , 1 - 2*sin(x^2) в противном случае */

Console.WriteLine("Введите значение x");
double x = Convert.ToDouble(Console.ReadLine());
DopTask01(x);

void DopTask01 (double x)
{
    double y = 0;
    if (x > 0)
    {
        y = Math.Pow(Math.Sin(Math.PI*x/180), 2);
        Console.WriteLine ("y = " + y);
    }
    else
    {
        y = (1 - 2*(Math.Sin(Math.PI*(x*x)/180)));
        Console.WriteLine ("y = " + y);
    }
}