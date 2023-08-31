Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int colums = int.Parse(Console.ReadLine()!);
int[,] array = new int[rows, colums];

GetArray(array);
PrintArray(array);

int MinSum = 0;
int sum = SumNumbersLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++){
    int step = SumNumbersLine(array, i);
    if(sum > step){
        sum = step;
        MinSum = i;
    }
}

Console.WriteLine($"{MinSum} - строкa c наименьшей суммой {sum} элементов ");

int SumNumbersLine(int[,] array, int i){
    int sum = array[i, 0];
    for (int j = 0; j < array.GetLength(1); j++){
        sum += array[i,j];
    }
    return sum;
}

void GetArray(int[,] array)
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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

