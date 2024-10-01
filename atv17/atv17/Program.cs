int numeroposotivo;

Console.Write("digite um numero positivo ");

while (!int.TryParse(Console.ReadLine(), out numeroposotivo) || numeroposotivo <=0)
{
    Console.WriteLine("Por favor, insira um número inteiro positivo:");
    Console.Write("Define um número inteiro positivo");
}


Console.WriteLine($"Os valores ímpares até o número {numeroposotivo} são os:");
for (int i = 1; i <= numeroposotivo; i += 2)
{
    Console.WriteLine(i);
}

Console.Write("Digite uma tecla para encerrar.");
Console.ReadKey();
