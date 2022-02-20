// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int Input()
{
    Console.Write("Введите число элементов массива: ");
    string? inp = Console.ReadLine();
    int.TryParse(inp, out int number);
    return number;
}

int[] ArrayInit(int number)
{
    int[] array = new int[number];
    Random randomValue = new Random();

    for(int i = 0; i < number; i++)
    {
        array[i] = randomValue.Next(100, 1000);
    }
    return array;
}

void ArrPrint(int[] arr)
{

    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
}

void NumberOfEvenAndOdd(int[] arr)
{
    int countEven = 0;
    int countOdd = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            countEven++;
        }
        else
        {
            countOdd++;
        }
    }
    Console.Write($"Количество четных чисел: {countEven} Количество нечетных чисел: {countOdd}");
}

int number = Input();

int[] arr = ArrayInit(number);
ArrPrint(arr);
Console.WriteLine();
NumberOfEvenAndOdd(arr);