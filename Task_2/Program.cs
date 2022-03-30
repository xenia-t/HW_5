// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.

int N = Promt("Введите длину массива: ");

if (N > 0)
{
    int[] array = RandomArray(N);	
    PrintArray(array);
    Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях, составляет {FindSum(array)}");
}

else Console.WriteLine("Введено некорректное значение длины массива");



int Promt(String message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int[] RandomArray (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1,1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}


