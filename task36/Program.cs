 // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

 //Вводим значения для работы с массивом
int Prompt (string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
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

// Находим сумму элементов на нечетных позициях 
int GetSumUnevenIndexElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 !=0)
        {
            sum+= array[i];
        }
    }
    return sum;
}


int NumberLength = Prompt("Введите значение длины массива: ");

int NumberStart = Prompt("Введите начальное значение для заполнения массива: ");

int NumberEnd = Prompt("Введите конечное значение для заполнения массива: ");

int[] arrayNumbers = GenerateArray(NumberLength, NumberStart, NumberEnd);
PrintArray(arrayNumbers);

Console.WriteLine();

int SumElements = GetSumUnevenIndexElements(arrayNumbers);
Console.WriteLine($"Сумма элементовб стоящих на нечетных позициях = {SumElements}");

