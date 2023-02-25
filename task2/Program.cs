// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int InputInt(string message) // ввод числового значения с консоли 
{
    System.Console.Write($"{message} > ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value)) // проверка правильности ввода числа
    {
        return value;
    }
    System.Console.WriteLine("Ошибка: введено не целое число");
    Environment.Exit(1); // exit code программы при ошибке
    return 0; // функция возвращает 0, потому что надо что-то возвращать int
}

int SumDigitsInNumber(int num) // подсчитывает сумму цифр в числе
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

int myNumber = InputInt("Введите число");
System.Console.WriteLine($"Сумма цифр числа {myNumber} составляет {SumDigitsInNumber(myNumber)}");