Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int a = number % 2;
if (a == 0)
{
    Console.WriteLine($"{number} - четное число");
}
else
{
     Console.WriteLine($"{number} - нечетное число");
}

