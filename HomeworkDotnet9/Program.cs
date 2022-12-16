// See https://aka.ms/new-console-template for more information

// 64.

/*Console.Write("Type the N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N,1));

string PrintNumbers(int start, int end){
    if (start == end) {
        return start.ToString();}
    return(start + " " + PrintNumbers(start-1 ,end));
}*/

// 66.

/*Console.Write("Type the M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Type the N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(M,N));

int PrintNumbers(int M, int N){
    if (M == N) {
        return M;}
    return(M += PrintNumbers(M+1 ,N));
}*/

// 68.

/*Console.Write("Type the M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Type the N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"A({M},{N}) = {Akkerman(M, N)}");

int Akkerman(int m, int n)
{
    if (m == 0) {
        return n += 1;
    } if (m > 0 && n == 0) {
        return Akkerman(m - 1, 1);
    } else {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}*/

/* A(0, n) = n + 1,

A(1, n) = n + 2,

A(2, n) = 2n + 3,

A(3, n) = 2n+3 – 3 */

 