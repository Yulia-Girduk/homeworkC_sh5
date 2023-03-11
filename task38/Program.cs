// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Вещественные числа — это числа, у которых есть дробная часть.

 //Вводим значения для работы с массивом
int Prompt (string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Заполняем массив
double[] GenerateArray (int numLength)
{
    double[] arrayComplete = new double[numLength];
    Random random = new Random();
    for (int i = 0; i < arrayComplete.Length; i++)
    {
        arrayComplete[i] = random.NextDouble();
    }
    return arrayComplete;
}

//Выводим массив на экран
void PrintArray(double[] array)
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

//Находим разницу между максимальным и минимальным элементами массива
double GetDiffMaxAndMinElements(double[] array)
{
    
    double maxElement = array[0];
    double minElement = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (maxElement < array[i])
        {
            maxElement = array[i];
        }
        else
        {
            if (array[i] < minElement)
            {
                minElement =array[i];
            }
        }
    }
    
    Console.WriteLine($"Максимальный элемент = {maxElement}");
    Console.WriteLine($"Минимальный элемент = {minElement}");

    double numberDiff = maxElement - minElement;
    return numberDiff;

} 

int NumberLength = Prompt("Введите значение длины массива: ");

double[] arrayNumbers = GenerateArray(NumberLength);
PrintArray(arrayNumbers);

Console.WriteLine();

double diff = GetDiffMaxAndMinElements(arrayNumbers);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diff}");

