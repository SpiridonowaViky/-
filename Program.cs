Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine());

while (number < 100 || number > 999)
    {
        Console.WriteLine("Данное число не трехзначное,введите трехзначное число:");
        number = int.Parse(Console.ReadLine()); 
    }
    int number1 = number / 10;
    int number2 = number1 % 10;

    Console.WriteLine("Второй символ введенного числа = " + number2);
