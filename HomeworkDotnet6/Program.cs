// See https://aka.ms/new-console-template for more information

// 41.

/*Console.Write("Type the length of array ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size);

int count = 0;
for (int j = 0; j < size; j++) {
    if (array[j] > 0)
count++;
}

Console.WriteLine($"This is the massive: [{String.Join(",", array)}]");
Console.WriteLine($"from this massive {count} numbers are greater than 0");


int[] GetArray(int size, int minValue = -100, int maxValue = 100) {
    int[] result = new int[size];
    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(minValue, maxValue);
    } return result;
}*/

// 43.

/*Console.Write("Type the length of array ");
int size = int.Parse(Console.ReadLine()!);
if (size < 6) {
    Console.Write("Type the length of array must atleast have 6 numbers");
} else {
int[] array = GetArray(size);


Console.WriteLine($"This is the massive: [{String.Join(",", array)}]");
ChangePositions(array);
Console.WriteLine($"The massive sorted from smallest to largest is [{String.Join(",", array)}]"); }


int[] GetArray(int size, int minValue = 0, int maxValue = 100) {
    int[] result = new int[size];
    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(minValue, maxValue);
    } return result;
}
void ChangePositions(int[] array) {
    for (int k = 0; k < array.Length; k++) {
    for (int j = 0; j < array.Length - 1; j++) {
        if (array[j] > array[j+1]) {
            int temp = array[j+1];
            array[j+1] = array[j];
            array[j] = temp;
        }
    }
}  
}  */
