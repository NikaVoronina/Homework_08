Console.Clear();

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк первой матрицы: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int colum1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов второй матрицы: ");
int colum2 = int.Parse(Console.ReadLine()!);

int[,] FirstMartrix = new int[str, colum1];
FillArrayRandomNumbers(FirstMartrix);
PrintArray(FirstMartrix);

int[,] SecondMartrix = new int[colum1, colum2];
FillArrayRandomNumbers(SecondMartrix);
PrintArray(SecondMartrix);

int[,] resultMatrix = new int[str, colum2];

MultiMatrix(FirstMartrix, SecondMartrix, resultMatrix);
Console.WriteLine($"Произведение двух матриц:");
PrintArray(resultMatrix);

void MultiMatrix(int[,] FirstMartrix, int[,] SecondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < FirstMartrix.GetLength(1); k++)
      {
        sum += FirstMartrix[i,k] * SecondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
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
            Console.Write("{0,6:F2}", array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}