Console.WriteLine("Podaj Liczby oddzielone spacją");
string liczby = Console.ReadLine();
string[] tablicaLiczb = liczby.Split(' ');
string[] sortedTablicaLiczb = tablicaLiczb.OrderBy(x => int.Parse(x)).ToArray();


int n = int.Parse(sortedTablicaLiczb[sortedTablicaLiczb.Length-1]);

Dictionary<int, bool> primeNumbers2 = new Dictionary<int, bool>();

foreach (var item in sortedTablicaLiczb)
{
    primeNumbers2.Add(int.Parse(item), true);
}

List<int> primeNumbers = new List<int>();
bool[] isPrime = new bool[n + 1];

for (int i = 2; i <= n; i++)
{
    isPrime[i] = true;
}

for (int i = 2; i <= Math.Sqrt(n); i++)
{
    if (isPrime[i])
    {
        for (int j = i * i; j <= n; j += i)
        {
            isPrime[j] = false;
        }
    }
}

foreach (var item in primeNumbers2)
{
    if (isPrime[item.Key])
    {
        primeNumbers.Add(item.Key);
    }
}

Console.WriteLine("Liczby pierwsze mniejsze od {0} to:", n);
foreach (var prime in primeNumbers)
{
    Console.Write(prime + " ");
}


