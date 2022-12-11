// See https://aka.ms/new-console-template for more information

// 54.

/*Console.Write("Type the row's size: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Type the column's size: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m,n];
GetRandomArray(array);
PrintArray(array);
Console.WriteLine("####################");
ChangePositions(array);
PrintArray(array);


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
}
void ChangePositions(int[,] array) {
    for (int k = 0; k <= array.GetLength(1); k++) {
    for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1) - 1; j++) {
        if (array[i,j] < array[i,j+1]) {
            int temp = array[i,j+1];
            array[i,j+1] = array[i,j];
            array[i,j] = temp;
        }
    }
}}}*/

// 56.

/*Console.Write("Type the row's size: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Type the column's size: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m,n];
GetRandomArray(array);
PrintArray(array);
Console.WriteLine("");
int minSum = 0;
int sum = GetSum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = GetSum(array, i);
  if (sum > tempSum)
  {
    sum = tempSum;
    minSum = i;
  }
}
Console.WriteLine($"the row who has the least sum which is {sum} is row number {minSum+1}");


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
}
int GetSum(int[,] array, int i) {
    int sum = array[i,0];
            for (int j = 1; j < array.GetLength(1); j++) {
            sum += array[i,j];
            } return sum;
    }*/

// 60.

/*int x = 2;
int y = 2;
int z = 2;
int[,,] array3D = new int[x, y, z];
GetArray3D(array3D);
PrintArray(array3D);

void GetArray3D(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"X({i}), Y({j}), Z({k}) = {array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}*/