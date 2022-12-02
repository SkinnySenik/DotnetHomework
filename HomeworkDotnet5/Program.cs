// See https://aka.ms/new-console-template for more information

//34.

/*int size = 5;
int[] numbers = new int[size];

void FillRandom(int[] numbers) {
    for (int i = 0; i < numbers.Length; i++) {
        numbers[i] = new Random().Next(100,1000);
    }
}

FillRandom(numbers);
int count = 0;
for (int j = 0; j < numbers.Length; j++) {
    if (numbers[j] % 2 == 0)
count++;
}

Console.WriteLine($"This is the massive: [{String.Join(",", numbers)}]");
Console.WriteLine($"from this massive {count} numbers are even");*/

//36.

/*int size = 5;
int[] numbers = new int[size];

void FillRandom(int[] numbers) {
    for (int i = 0; i < numbers.Length; i++) {
        numbers[i] = new Random().Next(1,100);
    }
}

FillRandom(numbers);
int sum = 0;
for (int j = 1; j < numbers.Length; j+=2) {
sum = sum + numbers[j];
}

Console.WriteLine($"This is the massive: [{String.Join(",", numbers)}]");
Console.WriteLine($"from this massive the sum from odd numbers will be {sum}");*/

//37.

/*int[] numbers = new int[] {6, 7, 3, 6};

int size = 0;
if (numbers.Length % 2 == 0) {
    size = numbers.Length / 2;
} else {
    size = (numbers.Length / 2) + 1;
}

int[] array = new int[size];

int[] GetSecondMas(int[] array) {
int[] arr = new int[array.Length];
int z = numbers.Length - 1;
for (int j = 0; j <= z; j++) {
    arr[j] = numbers[j] * numbers[z];
    z--;
    } if (numbers.Length % 2 != 0){
        int j = (numbers.Length / 2);
    arr[j] = numbers[j];}
return arr;
}

Console.WriteLine($"This is the original massive: [{String.Join(",", numbers)}]");
Console.WriteLine($"However the massive has multiplied by the edge, so the new massive will be [{String.Join(",", GetSecondMas(array))}]");*/

// 38.

/*int size = 5;
int[] numbers = new int[size];

void FillRandom(int[] numbers) {
    for (int i = 0; i < numbers.Length; i++) {
        numbers[i] = new Random().Next(-10,11);
    }
}

FillRandom(numbers);
int max = 0;
int min = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"This is the original massive: [{String.Join(",", numbers)}]");
Console.WriteLine($"This massiv has largest number ({max}) and smallest ({min}) and their number difference is {max - min}");*/
