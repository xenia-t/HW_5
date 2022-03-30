// Задайте массив, заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.

int N = Promt("Введите длину массива: ");

if (N > 0)
{
	int[] array = RandomArray(N);	
    PrintArray(array);
    Console.WriteLine($"Количество четных чисел в массиве составляет {FindCout(array)}");
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
		array[i] = new Random().Next(100,1000);
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

int FindCout(int[] array)
{
	int cout = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0) cout++;
}
    return cout;
}

