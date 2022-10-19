

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)


double Fibonacci(double n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}


for (double i = 0; i < 50; i++)
{
    Console.WriteLine(Fibonacci(i));
}