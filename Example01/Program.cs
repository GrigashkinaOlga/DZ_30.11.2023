// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void Range(int N)
{
    if (N == 1)
    {
        Console.Write(N + " ");
        return;
    }

    Console.Write(N + " ");
    Range(N - 1);
}

Range(Prompt("Введите значение N: "));
