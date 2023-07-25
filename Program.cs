Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine()!);
int num = number%2;
int number2 = 1;
while (number > number2)
{
    Console.WriteLine($"{num}");
    number--;
}