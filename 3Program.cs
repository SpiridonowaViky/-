Console.WriteLine("Введите цифру, соответствующую дню недели:");
int number = int.Parse(Console.ReadLine());

while (number<1 || number >7)
{
    Console.WriteLine("Цифра не соответствует никакому дню недели. Введите цифру, соответствующую дню недели:");
    number = int.Parse(Console.ReadLine());
}

if (number>0 && number <6)
{
    Console.WriteLine("Рабочий день");
}
else
{
    Console.WriteLine("Выходной день");
}
