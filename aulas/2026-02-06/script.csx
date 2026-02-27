// dotnet tool install -g dotnet-script
// exec: dotnet script script.csx
int add1(int a, int b)
{
    return a + b;
}
Func<int, int, int> add2 = (a, b) => a + b;
int add3(int a, int b) => a + b;

Console.WriteLine($"soma = {add1(2, 3)}");
Console.WriteLine($"soma = {add2(2, 3)}");
Console.WriteLine($"soma = {add3(2, 3)}");

