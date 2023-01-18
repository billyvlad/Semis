Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int dig2 = number % 100 / 10;
int result = dig2;
Console.WriteLine($"{number} -> {result}");