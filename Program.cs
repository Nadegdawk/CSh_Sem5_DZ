Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command: ");
		switch (Console.ReadLine())
		{
			case "Task34": Task34(); break;
			case "Task36": Task36(); break;
            case "Task38": Task38(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}

void Task34()
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
{
	Console.WriteLine("The quantity of even numbers in the array");
    int length = ReadInt("lenght array");
    int[] array = GetRandomArray(length, 100, 1000);
    PrintArray(array);
    int a = QuantityEvenNumberArray(array);
    System.Console.WriteLine($"Even numbers: {a}");
    }

void Task36()
// Задача 36:Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
{
    Console.WriteLine("Sum of odd array elements");
    int length = ReadInt("lenght array");
    int xMin = ReadInt("Minimum");
    int xMax = ReadInt("Maximum");
    int[] array = GetRandomArray(length, xMin, xMax);
    PrintArray(array);
    int sum = SumOddElements (array);
    System.Console.WriteLine($"Sum of odd elements: {sum}");
}

void Task38()
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76
{
    Console.WriteLine("The difference between the maximum and minimum elements");
    int length = ReadInt("lenght array");
    int xMin = ReadInt("Minimum");
    int xMax = ReadInt("Maximum");
	int[] array = GetRandomArray (length, xMin, xMax-1);
	double[] arrayD = GetRandomArrayDouble (array);
    PrintArrayDouble(arrayD);
	System.Console.WriteLine("");
	System.Console.WriteLine($"Max: {MaxArray(arrayD)}    Min: {MinArray(arrayD)}");
	double d = MaxArray(arrayD) - MinArray(arrayD);
	System.Console.WriteLine($"The difference between the maximum and minimum elements: {d}");
}

int ReadInt(string argumentName)            //ввод данных пользователем
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)    //создание рандомного массива опред.длины
{
	int[] array = new int[length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}

int QuantityEvenNumberArray(int[] array)            //подсчет кол-ва четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    	if (IsEven(array[i]))
    	{
    		count ++;
    	}
}
    return count;  
}

bool IsEven(int number)         //четность числа
{
	return number % 2 == 0; // == - сравнение (результаты сравнения: true, false)
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

int SumOddElements (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsEven(i)) 
        sum += array[i];
    }
    return sum;
}

double[] GetRandomArrayDouble (int[] array)    //создание рандомного массива опред.длины
{
	double[] arrayD = new double[array.Length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		arrayD[i] = Math.Round(array[i] + random.NextDouble(), 2);
	}

	return arrayD;
}

void PrintArrayDouble (double[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} | ");
	}
}

double MinArray (double[] array)
{
	double minArray = array[0];
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i]<=minArray) minArray = array[i];
	}
	return minArray;
}

double MaxArray (double[] array)
{
	double maxArray = array[0];
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i]>=maxArray) maxArray = array[i];
	}
	return maxArray;
}
