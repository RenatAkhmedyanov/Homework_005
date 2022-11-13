Console.WriteLine("Программа, которая считает количество чётных чисел в массиве.");

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = GetArray(n);
PrintArray(array);
Console.WriteLine();
int result = CountEvenElements(array);
Console.WriteLine("Количесвто четных элементов в массиве: " + result);

int[] GetArray(int n)
{
    int[] array = new int[n];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
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

int CountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}