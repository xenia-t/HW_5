//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

int N = Promt("Введите длину массива: ");

if (N > 0)
{
    double[] array = RandomArray(N);	
    PrintArray(array);
    double difference = FindMax(array) - FindMin(array);
    Console.WriteLine("Разница между максимальным и минимальным элементами массива составляет {0:0.000}", difference);
}

else Console.WriteLine("Введено некорректное значение длины массива");



int Promt(String message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

double[] RandomArray (int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
	}
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0 : 0.000}", array[i]);
        Console.Write(" ");
    }
    Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}

