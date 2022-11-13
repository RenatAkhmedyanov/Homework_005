Console.WriteLine("Программа, которая считает разницу между максимальным и минимальным элементом массива.");

Console.Write("Введите количество элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);

double[] array = GetArray(n);
PrintArray(array);

Console.WriteLine();

double min = GetMin(array);
double max = GetMax(array);

double result = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + Math.Round(result, 2));

double[] GetArray(int n)
{
    double[] array = new double[n];
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = double.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("Полученный массив: {");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write(array[i] + " | ");
        else Console.Write(array[i]);
    }
    Console.Write("}");
}

double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}