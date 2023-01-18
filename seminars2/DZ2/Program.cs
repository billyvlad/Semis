Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numbers = Convert.ToString(number);
if (numbers.Length > 2)
{
  Console.WriteLine("третья цифра - " + numbers[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}



