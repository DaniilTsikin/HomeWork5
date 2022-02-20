/*  В Указанном массиве вещественных чисел 
найдите разницу между максимальным и минимальным элементом.*/

//Задаём число элементов в массиве
double Input()
{
    Console.Write("Введите число элементов массива: ");
    string? inp = Console.ReadLine();
    double.TryParse(inp, out double number);
    return number;
}

//Метод для инициализации массива вещественных чисел
double[] ArrayInit(double number)
{
    double[] arr = new double[(int)number];
    Random randomizer = new Random();
    for(int i = 0; i < number; i++)
    {
    arr[i] = randomizer.Next(0, 100) + randomizer.NextDouble();
    }
    return arr;
}

//Метод для печати массива
void ArrPrint(double[] arr)
{

    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
}

//Метод для нахождения разницы между максимальным и минимальным значениями
double Difference(double[] arr)
{
    double result = 0;
    double max = arr[0];
    double min = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(max < arr[i])
        {
            max = arr[i];
        }
        if(min > arr[i])
        {
            min = arr[i];
        }
    }
    Console.WriteLine($"Минимальное:{min} и Максимальное:{max} значения");
    result = max - min;
    return result;
}

//Инициализация переменных, для вызова методов
double number = Input();
double[] arr = ArrayInit(number);
//Вызов метода печати массива
ArrPrint(arr);
Console.WriteLine();

double result = Difference(arr); 
Console.WriteLine($"Разница между ними: {result}");