```csharp
Lists
List<string> names = new List<string>();
List<int> numbers = new List<int> { 1, 2, 3 };

names.Add("Alice");
names.AddRange(new[] { "José", "João" });

numbers.ForEach(n => Console.WriteLine(n));

string first = names[0];
names[0] = "Maria";

names.Remove("João");
names.RemoveAt(0);
names.RemoveAll(x => x.StartsWith("J"));
names.Clear();

bool contains = numbers.Contains(2);
int index = numbers.IndexOf(3);

int count = numbers.Count;
numbers.Sort();
numbers.Reverse();


int found = numbers.Find(n => n > 2);
List<int> filtered = numbers.FindAll(n => n > 1);
names.RemoveAll(x => x.StartsWith("C"));
Dictionary
using System.Collections.Generic;

Dictionary<string, int> ages = new Dictionary<string, int>();
Dictionary<string, string> capitals = new Dictionary<string, string>
{
    { "CE", "Ceará" },
    { "PE", "Pernambuco" },
    ["E"] = "Erro"
};

ages.Add("Maria", 30);
ages["José"] = 25;

int aliceAge = ages["Alice"];
bool success = ages.TryGetValue("José", out int idadeJose);

bool containsKey = ages.ContainsKey("Maria");
bool containsValue = ages.ContainsValue(25);

bool removed = ages.Remove("João");

foreach (KeyValuePair<string, int> pair in ages)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

foreach (var (name, age) in ages)
{
    Console.WriteLine($"{name}: {age}");
}
LINQ (Language Integrated Query)
using System.Linq;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Filtragem
var evens = numbers.Where(n => n % 2 == 0);
var greaterThanFive = numbers.Where(n => n > 5);

// Transformação
var doubled = numbers.Select(n => n * 2);
var numberObjects = numbers.Select(n => new { Value = n, IsEven = n % 2 == 0 });

// Ordenação
var ascending = numbers.OrderBy(n => n);
var descending = numbers.OrderByDescending(n => n);
var complex = numbers.OrderBy(n => n % 3).ThenByDescending(n => n);

// Agregação
int sum = numbers.Sum();
int min = numbers.Min();
int max = numbers.Max();
double average = numbers.Average();
int product = numbers.Aggregate((a, b) => a * b);

// QUantificadores
bool allEven = numbers.All(n => n % 2 == 0);
bool anyEven = numbers.Any(n => n % 2 == 0);
bool containsSeven = numbers.Contains(7);

// Partição
var firstThree = numbers.Take(3);
var skipFirstThree = numbers.Skip(3);
var takeLast = numbers.TakeLast(2);
var skipLast = numbers.SkipLast(2);

var pageNumber = 2;
var pageSize = 10;

var pagedItems = items
    .Skip((pageNumber - 1) * pageSize)
    .Take(pageSize)
    .ToList();

// Operações de elemento
int first = numbers.First();
int firstEven = numbers.First(n => n % 2 == 0);
int lastOdd = numbers.Last(n => n % 2 != 0);

int single = numbers.Where(n => n == 5).Single();

// Grouping
var groups = numbers.GroupBy(n => n % 3);
foreach (var group in groups)
{
    Console.WriteLine($"Remainder {group.Key}: {string.Join(", ", group)}");
}

// Sintaxe de consulta (alternativa à sintaxe do método)
var queryResult = from n in numbers
                  where n > 5
                  orderby n descending
                  select n * 2;
```
