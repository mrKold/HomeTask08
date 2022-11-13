// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void InputMatrix(int[,] matrix)
{
    int temp = 1, i = 0, j = 0;
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i,j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0)-1)
            i++;
        else if (i >= j  && i + j > matrix.GetLength(1)-1)
            j--;
        else 
            i--;
    }
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int m = 0; m < matrix.GetLength(1); m++)
            Console.Write(matrix[k, m] + " \t");
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("Заполненный массив: \n");
InputMatrix(matrix);