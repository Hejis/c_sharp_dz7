// Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.


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

void PrintNumber(int n, int m, int[,] numbers)
{
if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
        Console.WriteLine("Такого элемента нет");
    }
else
{
        Console.WriteLine($"Значение элемента{numbers[n - 1, m - 1]}");
    }
}



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
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
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
Console.WriteLine();
int line =Prompt("Введите номер строки: ");
Console.WriteLine();
int column = Prompt("Введите номер столбца: ");
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
PrintNumber(line, column, numbers);