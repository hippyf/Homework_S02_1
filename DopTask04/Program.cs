// Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10

int [] array = new int[10];
Task4(array);

void Task4 (int[] array)
{
    int index = 0;
    int i = 1;
    while (index < array.Length)
    {
        array[index] = i;
        Console.Write(array[index] + " ");
        i++;
        index++;
    }
    Console.WriteLine();
}