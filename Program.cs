Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());

int CalculateSumm(int M, int N)
{
int start = M;
int end = N;
if(M > N)
{
start = N;
end = M;
}
return (end + start)*(end - start + 1)/2;
}

Console.WriteLine(CalculateSumm(M, N));
	