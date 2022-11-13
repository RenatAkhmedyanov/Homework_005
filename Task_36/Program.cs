Console.WriteLine("Программа, которая находит сумму элементов массива, стоящих на нечетных позициях.");
Console.WriteLine();

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = GetArray(n);
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

int result = SumOddPositions(array);
Console.WriteLine("Сумма элементов массива, стоящих на нечетных позициях: " + result);

int[] GetArray(int n)
{
    int[] array = new int[n];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next();
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("Полученный массив: {");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write(array[i] + " | ");
        else Console.Write(array[i]);
    }
    Console.Write("}");
}

int SumOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}