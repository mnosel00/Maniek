List<int> ints = new List<int>();

Console.WriteLine("Podaj zakres liczb odzielonych spacją");
string inputInts = Console.ReadLine();

string[] inputedInts = inputInts.Split(' ');

int firstInt = int.Parse(inputedInts[0]);
int lastInt = int.Parse(inputedInts[1]);

for (int i = firstInt; i < lastInt; i++)
{
    ints.Add(i);
}

