// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//Вводим значения для рабты с массивом
int Prompt (string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Проверяем на соблюдения условий ввода
void CheckOut (int numberCheck)
{
    if ((numberCheck < 100) || (numberCheck > 999))
    {
        Console.WriteLine("Введенное число не является трехзначным!!!");
    }
    if (numberCheck < 0 )
    {
       Console.WriteLine("Введенное число является отрицательным!!!"); 
    }
}

// Заполняем массив
int[] GenerateArray (int numLength, int numStart, int numEnd)
{
    int[] arrayComplete = new int[numLength];
    Random random = new Random();
    for (int i = 0; i < arrayComplete.Length; i++)
    {
        arrayComplete[i] = random.Next(numStart, numEnd+1);
    }
    return arrayComplete;
}

//Выводим массив на экран
void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length-1)
        {
            Console.Write($"{array[i]} ");// выводим все элементы массива,кроме последнего
        }
        else
        {
            Console.Write($"{array[i]}");// выводим последний элемент массива
        }
    }
    Console.Write($"]");
}

//Считаем количество четных элементов
int CalculateEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            count++;
        }
        
    }
    return count;
}

int NumberLength = Prompt("Введите значение длины массива: ");

int NumberStart = Prompt("Введите положительное трехзначное начальное значение для заполнения массива: ");
CheckOut(NumberStart);

int NumberEnd = Prompt("Введите положительное трехзначное конечное значение для заполнения массива: ");
CheckOut(NumberEnd);

int[] arrayNumbers = GenerateArray(NumberLength, NumberStart, NumberEnd);
PrintArray(arrayNumbers);

Console.WriteLine();

int CountElements = CalculateEvenElements(arrayNumbers);
Console.WriteLine($"Количество четных элементов в массиве = {CountElements}");