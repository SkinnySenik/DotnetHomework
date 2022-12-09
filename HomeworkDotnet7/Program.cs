// See https://aka.ms/new-console-template for more information

// 47.

/*Console.Write("Type the size of m :");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Type the size of n :");
int n = int.Parse(Console.ReadLine()!);
double[,] array = new double[m,n];
GetRandomArray(array);
PrintArray(array);


void GetRandomArray(double[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
    }
    } 
}

void PrintArray(double[,] array)
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
}*/

// 50.

/*Console.Write("Type the place for row :");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Type the place for column :");
int j = int.Parse(Console.ReadLine()!);
int[,] array = new int[5,5];
GetRandomArray(array);

if (i > array.GetLength(0) || j > array.GetLength(1))
{
    Console.WriteLine("E R R O R! the search is out of bounds. Please try again!");
}
else
{
    PrintArray(array);
    Console.WriteLine($"the placement for element on row {i} and column {j} will be {array[i-1,j-1]}");
}

void GetRandomArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
        array[i, j] = new Random().Next(0, 100);
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
}*/

// 52.

/*Console.Write("Type the row's size: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Type the column's size: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m,n];
GetRandomArray(array);
PrintArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    sum = sum / m;
    if (sum % 1 == 0) {
    Console.Write($" {sum};");
    }
    else {
    Console.Write($" {sum:f1};");
    }
}
Console.WriteLine();


void GetRandomArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
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
}*/