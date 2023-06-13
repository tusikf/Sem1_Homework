// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите любое число (желательно до 10): ");
int number = int.Parse(Console.ReadLine()!);

int k = 2;

Console.WriteLine($"Последовательность чётных чисел от 1 до вашего числа { number } - это:");

while ( k <= number)
{
    if (k % 2 ==0) 
    {
                Console.WriteLine(k);
    }
    k ++;
}