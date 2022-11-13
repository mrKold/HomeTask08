// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void InputFirstMatrix(int[,] FirstMatrix)
{
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            FirstMatrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{FirstMatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void InputSecondMatrix(int[,] SecondMatrix)
{
    for (int i = 0; i < SecondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < SecondMatrix.GetLength(1); j++)
        {
            SecondMatrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{SecondMatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ProzMatrix(int[,] FirstMatrix, int [,] SecondMatrix)
{
    int [,] ResultMatrix = new int[FirstMatrix.GetLength(0), FirstMatrix.GetLength(1)];
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++) 
        {
            ResultMatrix[i,j] = FirstMatrix[i,j] * SecondMatrix[i,j];
            Console.Write($"{ResultMatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] FirstMatrix = new int[n, m];
int[,] SecondMatrix = new int[n, m];
Console.WriteLine("Первая матрица: ");
InputFirstMatrix(FirstMatrix);
Console.WriteLine("Вторая матрица: ");
InputSecondMatrix(SecondMatrix);
Console.WriteLine("Произведение матриц: ");
ProzMatrix(FirstMatrix, SecondMatrix);