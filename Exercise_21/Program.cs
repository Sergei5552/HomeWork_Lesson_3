Console.Write("Введите координату X для точки A: ");
double ax = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y для точки A: ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z для точки A: ");
double az = Convert.ToDouble(Console.ReadLine());


Console.Write("Введите координату X для точки B: ");
double bx = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y для точки B: ");
double by = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z для точки B: ");
double bz = Convert.ToDouble(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
Console.WriteLine($"Расстояние между точками A и B: {Math.Round(distance, 2)}");

