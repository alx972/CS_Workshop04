// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int InputInt(string message) // ввод числового значения с консоли 
{
    Console.Write($"{message} > ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value)) // проверка правильности ввода числа
    {
        return value;
    }
    Console.WriteLine("Ошибка: введено не целое число");
    Environment.Exit(1); // exit code программы при ошибке
    return 0; // функция возвращает 0, потому что надо что-то возвращать int
}

int[] GenerateArray(int length, int minValue, int maxValue) // генератор массива с заданными параметрами
{
    int[] result = new int[length];
    Random rnd = new Random();
    for (int i=0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] array) //вывод массива на экран
{
    Console.Write($"[{array[0]}");
    for (int i=1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.WriteLine("]");
}

int length = InputInt("Введите длину массива");
int minValue = InputInt("Введите минимальное значение генерируемого массива");
int maxValue = InputInt("Введите максимальное значение генерируемого массива");
int[] myArray = GenerateArray(length, minValue, maxValue);
PrintArray(myArray);