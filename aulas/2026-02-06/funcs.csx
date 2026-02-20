// dotnet tool install -g dotnet-script
// exec: dotnet script script.csx
Func<int, int, float> div = (a,b) => (float)a / b;
Console.WriteLine(div(3,2));
float calc(int a, int b, Func<int, int, float> op) 
{
    return op(a, b);    
}
Console.WriteLine(calc(2, 3, div));

bool check(int a, int b) => a == b; 
Console.WriteLine($"{ check(2,2) }");