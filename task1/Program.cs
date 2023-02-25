// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. (Без использования Math.Pow)

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

double PowerOf(int num, int pow) // возведение в степень числа
{
    double result = num;
    if (pow == 0) // если степень равна нулю
    {
        result = 1; 
    }
    else // если степень отличается от нуля
    {
        for (int i=1; i < Math.Abs(pow); i++)
        {
            result = result * num;
        }
    }
    if (pow < 0) // если степень меньше нуля
    {
        result = 1 / result;
    }
    return result;
}

int myNumber = InputInt("Введите число");
int myPower = InputInt("Введите степень числа");
System.Console.WriteLine($"{myNumber} в степени {myPower} равно {PowerOf(myNumber, myPower):f3}");