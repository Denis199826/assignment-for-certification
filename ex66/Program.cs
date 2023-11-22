// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int SummaNumbersBetweenMandN (int M, int N)
{
    int sum = M;
    if (M==N)
    {
        return M;
    }
    if (M>N)
    {
        int res = N;
        N++;
        res = res + SummaNumbersBetweenMandN (M, N++);
        return res;
    }
    else 
    M++;
    sum = sum + SummaNumbersBetweenMandN (M++, N);
    return sum; 
}

int M = ReadInt("Введите первое число");
int N = ReadInt("Введите второе число");
Console.WriteLine(SummaNumbersBetweenMandN(M, N));