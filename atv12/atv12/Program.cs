int nota;
Console.Write("informe sua nota:");
int.TryParse(Console.ReadLine(), out nota);



if (nota >= 90 && nota < 101) 
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("você tirou A!");
}
if (nota >= 80 && nota <= 89)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("você tirou B!");
}
if (nota >= 70 && nota <= 79 )
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("você tirou C");
}
if (nota >= 60 && nota <= 69)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("você tirou D :(");
}
if ( nota < 69)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("você tirou F :(");
}

Console.WriteLine("programa encerrado");
Console.ReadKey();
