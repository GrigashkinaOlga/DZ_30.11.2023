// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int FunсAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return FunсAckermann(m - 1, 1);
    }
    else return FunсAckermann(m - 1, FunсAckermann(m, n - 1));
}

bool ValiFunсAckermann(int m, int n)
{
    if (m < 0 || n < 0)
    {
       Console.WriteLine("Введите положительные значения m и n");
       return false;
    }
return true;
}

int m = Prompt("Введите значение m: ");
int n = Prompt("Введите значение n: ");

if (ValiFunсAckermann(m, n))
{
    Console.WriteLine($"A({m}, {n}) = {FunсAckermann(m, n)}");
}
