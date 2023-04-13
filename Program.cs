Console.WriteLine("Метод Console.WriteLine");
Console.WriteLine("Hello");
Console.WriteLine("World");
Console.WriteLine("!!!");
Console.WriteLine("Метод Console.Write");
Console.Write("Hello");
Console.Write(" World ");
Console.Write("!!!");
Console.ReadLine();

for(int i = 1; i < 10; i++)
{
    for(int j = 1; j < 10; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}
Console.ReadLine();