Console.Write("Введите пятизначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());


int numberOne = userNumber % 100;
int numberTwo = userNumber / 1000;


if (numberOne != numberTwo & numberOne * numberTwo == numberTwo * numberOne)
{
    Console.Write($"{userNumber} - палиндром"); 
}
else
    Console.Write($"{userNumber} - не палиндром");
