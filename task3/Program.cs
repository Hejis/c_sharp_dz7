// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.


int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение невозможно преобразовать в число");
}





void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void ArrayAverage(int[,] numbers, int n, int m)
{   
    for (int j = 0; j < m; j++)
    {
        double average = 0;
        for (int i = 0; i < n; i++)
        {
            average = (average + numbers[i, j]);
        }
        average = average / n;
        Console.Write(average + "; ");
    }
}


Console.WriteLine();

int linesNumber = Prompt("Введите число строк: ");

int columnsNumber = Prompt("Введите число столбцов: ");
int[,] numbers = new int[linesNumber, columnsNumber];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

 Console.WriteLine("Среднее значение массива в стролбцах: ");
 ArrayAverage(numbers, linesNumber, columnsNumber);