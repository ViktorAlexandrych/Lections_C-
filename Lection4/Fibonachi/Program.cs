
double f(double n)
{
	if (n == 1 || n == 2) return 1;
	else return f(n - 1) + f(n - 2);
}
for (double i = 1; i < 50; i++)
{
	System.Console.WriteLine($"f({i}) = {f(i)}");
}