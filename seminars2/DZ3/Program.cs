Console.WriteLine("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 6 || number == 7) // будет True, но если поставить && то будет False
{
    Console.WriteLine("Этот день - выходной");
}
else if (number < 1 || number > 7) 
{
    Console.WriteLine("если у тебя столько дней в неделе, то пора на выходной)))))");
}
else
{
    Console.WriteLine("Это рабочий день, иди страдай)");
}