// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void PrintArr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ; ");
        }
        Console.WriteLine();
    }
}

double[,] FillDoubleArray(int rows, int columns, int max)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Convert.ToDouble (new Random().Next(max)*0.01);
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

int rows = Data("Введите количество строк : ");
int columns = Data("Введите количество столбцов : ");
double[,] matrix = FillDoubleArray(rows, columns, 20);
PrintArr(matrix);