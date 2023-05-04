Console.Write("Введите положительное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= userNumber; i++)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}