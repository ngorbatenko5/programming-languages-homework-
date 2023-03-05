Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;
if (number > 1)
{
    while (evenNumber <= number)
    {
        Console.Write(evenNumber+ " ");
        evenNumber = evenNumber + 2;
    }
}
else
{
    Console.WriteLine("Вы ввели ненатуральное число:");
}
