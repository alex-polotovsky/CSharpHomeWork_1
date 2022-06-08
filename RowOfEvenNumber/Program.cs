/* Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N. */

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n <= 1)
{
    Console.WriteLine("Number out of range.");
}
else
{
    int EvenNumber = 2;

    Console.Write("Чётные числа: ");

    while (EvenNumber <= n)
    {
        Console.Write(" " + EvenNumber);
        EvenNumber += 2;
    }
}



