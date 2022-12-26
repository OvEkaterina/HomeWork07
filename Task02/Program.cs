// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void FoundElement(int[,] array, int m, int n)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int p = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (i == m & j == n)
            {
                Console.WriteLine($" Значение элемента [{m},{n}] равно {array[i, j]}");
                p++;
            }       
        }
    }
    if (p == 0) Console.WriteLine($" Числа с позицией [{m},{n}]  в массиве нет!");
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int Data(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] array = FillArray(3, 4, 1, 999);
int n = Data("Введите номер позицию элемента номер 1: ");
int m = Data("Введите номер позицию элемента номер 2: ");
PrintArr(array);
FoundElement(array, n, m);