// Console.WriteLine("Введите количество строк массива:");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов массива:");
// int colums = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, colums, 0, 10);
// PrintArray(array);

// //Создание массива
// int[,] GetArray(int m, int n, int MinValue, int MaxValue)
// {
//     int[,] res = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             res[i,j] = new Random().Next(MinValue, MaxValue + 1);
//         }
//     }
//     return res;
// }
// //Печать массива
// void PrintArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write  ($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите количество строк:");
int colums = Convert.ToInt32(Console.ReadLine()!);

double[,] array = new double[rows, colums];

GetArray(array);
PrintArray(array);

//Массив
void GetArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            array[i,j] = new Random().Next(-99,99) / 100.0;
        }
    }
}

//Печать массива
void PrintArray(double[,] array)
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


