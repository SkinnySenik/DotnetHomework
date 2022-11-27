// See https://aka.ms/new-console-template for more information

// 25.

/*Console.Write("Type the primary number ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Type the square number ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSqr(A));

int GetSqr(int sum) {
    for (int i = 1; i < B; i++) {
      sum = sum * A;
    }
    return sum;
}*/

// 27.

/*Console.Write("Type the number ");
int Num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"the sum of number {Num} will be {GetSum(Num)}");

int GetSum(int number) {
    int sum = 0;
    while (number > 0) {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}*/

// 29.
/*int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetBinaryArray(int size) {
    int[] result = new int[size];
    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(1,100);
    }
    return result;
}*/