//Найти сумму чисел одномерного массива стоящих на нечетной позиции.

//Инициализируем массив
int [] arr = new int [20];

//Создаем метод заполнения массива
void FullArr(int[] arr)
{
    Random randomizer = new Random();

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(1, 30);    
    }
}

//Метод печати массива
void ArrPrint(int[] arr)
{

    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
}

//Метод вычисления суммы чисел массива находящихся на нечётных позициях
int SumOfOddIndex(int[] arr)
{
    int sumOdd = 0;
    for(int i = 1; i < arr.Length; i += 2)
    {
        sumOdd += arr[i];
    }
    return sumOdd;
}

FullArr(arr);
ArrPrint(arr);

//Инициализируем переменную для вызова метода SumOfOddIndex
int sumOddIndex = SumOfOddIndex(arr);
Console.WriteLine();
Console.Write($"Сумма чисел находящихся на нечётных позициях = {sumOddIndex}");