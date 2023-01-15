// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int current = -1 * number;
while(current <= number)
{
    Console.Write($"{current}, ");
    current++;
}