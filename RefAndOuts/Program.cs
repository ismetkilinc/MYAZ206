void Arttir(ref int x)
{
    x++;
}


void Azalt(out int y)
{
    y = 19;
    
}

int x = 10;
Arttir(ref x);
Console.WriteLine($"X is {x}");

int y = 100;
Arttir(ref x);
Azalt(out y);
Console.WriteLine($"Y is {y}");



