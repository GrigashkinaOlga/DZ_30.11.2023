// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int CountSum(int M, int N, int sum)
{
    if (N >= M)
    {
        sum = sum + N;
        return CountSum(M, N - 1, sum);;
    }
    
return sum;
}

bool ValiSum(int M, int N)
{
    if (N < M)
    {
       Console.WriteLine("Введите значение N, больше чем M");
       return false;
    }
return true;
}

int M = Prompt("Введите значение M: ");
int N = Prompt("Введите значение N: ");

if (ValiSum(M, N))
{
    Console.WriteLine(CountSum(M, N, 0));
}
