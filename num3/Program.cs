int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

temp(m,n);


// вызов функции Аккермана
void temp(int m, int n)
{
    Console.Write(akker(m, n)); 
}

// функция Аккермана
int akker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return akker(m - 1, 1);
    }
    else
    {
        return (akker(m - 1, akker(m, n - 1)));
    }
}