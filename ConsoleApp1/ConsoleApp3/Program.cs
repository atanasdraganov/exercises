// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Въведете размерност на квадратната матрица: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];
Console.WriteLine("Въведете елементите на масива:");

for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        Console.Write("matrix[{0},{1}] = ", row, col);
        matrix[row, col] = int.Parse(Console.ReadLine());
    }
}

Console.Write("Въведете индекс на реда и колоната: ");
int k = int.Parse(Console.ReadLine());


int[,] newMatrix = new int[n - 1, n - 1];

for (int row = 0; row < n - 1; row++)
{
    int actualRow = row < k - 1 ? row : row + 1;

    for (int col = 0; col < n - 1; col++)
    {
        int actualCol = col < k - 1 ? col : col + 1;

        newMatrix[row, col] = matrix[actualRow, actualCol];
    }
}

// Извеждане на новия масив
Console.WriteLine("Новият масив е:");

for (int row = 0; row < n - 1; row++)
{
    for (int col = 0; col < n - 1; col++)
    {
        Console.Write(newMatrix[row, col] + " ");
    }

    Console.WriteLine();
}

Console.ReadKey();