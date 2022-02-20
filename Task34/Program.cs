//Написать программу замену элементов массива на противоположные.

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
        array[i] = randomValue.Next(-100, 100);
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

void EditElement(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}

int value = Input();

int [] arr = ArrayInit(value);

ArrPrint(arr);
Console.WriteLine();
EditElement(arr);
ArrPrint(arr);