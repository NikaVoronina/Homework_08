Console.Clear();

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите размер X: ");
int X = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер Y: ");
int Y = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер Z: ");
int Z = int.Parse(Console.ReadLine()!);
int countNums = 100;

if (X * Y * Z > countNums)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] resultNums = array3D(X, Y, Z);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.WriteLine($"{resultNums[i, j, k]}({i},{j},{k})");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] array3D(int X1, int Y2, int Z2)
{
    int[,,] array = new int[X1, Y2, Z2];
    int[] massive = new int[countNums];
    int num = 10;
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = num++;
    }
    for (int i = 0; i < massive.Length; i++)
    {
        int randomInd = new Random().Next(0, massive.Length);
        int temp = massive[i];
        massive[i] = massive[randomInd];
        massive[randomInd] = temp;
    }
    int valueIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = massive[valueIndex++];
            }
        }
    }
    return array;
}