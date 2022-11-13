Console.WriteLine("Программа, которая находит максимальный, минимальный элементы массива, их индексы, средее арифметическое всех элементов и медианное значение первоначального массива.");

Console.Write("Введите количество элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = GetArray(n);

PrintArray(array);

Console.WriteLine();

int min = array.Min();
int max = array.Max();

int minIndex = GetMinIndex(array);
int maxIndex = GetMaxIndex(array);

int sum = GetSum(array);
double average = GetAverage(sum, n);

double[] secondArray = GetSecondArray();
PrintSecondArray(secondArray);


Console.WriteLine("Отсортируем исходный массив в порядке возрастания.");
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
double mediana = GetMediana(array, n);
Console.WriteLine("Медианное значение исходного массива: " + mediana);

int[] GetArray(int n)
{
    int[] array = new int[n];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100,101);
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

int GetMinIndex(int[] array)
{
    int minIndex = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int GetMaxIndex(int[] array)
{
    int maxIndex = 0;
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            maxIndex = i;
        }
    }
    return maxIndex;
}

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

double GetAverage(int sum, int n)
{
    double average = 1.0 * sum / n;
    return Math.Round(average, 2);
}

double[] GetSecondArray()
{
    double[] secondArray = new double[5];
    secondArray[0] = min;
    secondArray[1] = minIndex;
    secondArray[2] = max;
    secondArray[3] = maxIndex;
    secondArray[4] = average;
    return secondArray;
}

void PrintSecondArray(double[] secondArray)
{
    Console.Write("Новый массив: {");
    for (int i = 0; i < secondArray.Length; i++)
    {
        if (i != secondArray.Length - 1) Console.Write(secondArray[i] + " | ");
        else Console.Write(secondArray[i]);
    }
    Console.WriteLine("} в котором:");
    Console.WriteLine(secondArray[0] + " - минимальное значение в исходнои массиве");
    Console.WriteLine(secondArray[1] + " - индекс минимального значения");
    Console.WriteLine(secondArray[2] + " - максимальное значение в исходном массиве");
    Console.WriteLine(secondArray[3] + " - индекс максимального значения");
    Console.WriteLine(secondArray[4] + " - среднее арифметическое всех элементов исходного массива");
}

double GetMediana(int[] array, int n)
{
    double mediana;
    if (n % 2 == 0)
    {
        mediana = 1.0* (array[n / 2] + array[(n / 2) - 1]) / 2;
    }
    else
    {
        mediana = array[n / 2];
    }
    return mediana;
}