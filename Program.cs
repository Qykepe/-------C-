Console.Write("Введите угловой коэффициент k1:");
double k1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введитt свободный коэффициент b1:");
double b1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите угловой коэффициент k2:");
double k2 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введитt свободный коэффициент b2:");
double b2 = Convert.ToInt32(Console.ReadLine()!);


double x = (b1 - b2)/(k2-k1);
double y = k1 * x + b1;

Console.WriteLine($"Две прямые пересекутся в точке с координатами OX: {x}, OY: {y}");