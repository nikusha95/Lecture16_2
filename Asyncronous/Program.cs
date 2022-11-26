// See https://aka.ms/new-console-template for more information

int r1 = Sum(1, 2);
var r2 = await SumAsync(1, 2);

Console.WriteLine(r1);
Console.WriteLine(r2);

int res = await SumResult(1, 2);

Console.WriteLine(res);

async Task<int> SumResult(int a, int b)
{
    return  await SumAsync(a, b);
}
Task<int> SumAsync(int a, int b)
{
    return Task.FromResult(a + b);
}
int Sum(int a, int b)
{
    return a + b;
}

void Print(string message){
    Console.WriteLine(message);
}

async Task PrintAsync(string message)
{
    var r3 =await SumAsync(1, 5);
    Console.WriteLine(message);
}
