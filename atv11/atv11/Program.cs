
try
{
    Console.Write("Digite um número ");
    int numero = int.Parse(Console.ReadLine());

    Console.Write("Digite outro número ");
    int numero2 = int.Parse(Console.ReadLine());

    int resultado = numero + numero2;
    Console.WriteLine($"o resultado da soma é: {resultado}");
}

catch (FormatException)
{
    Console.WriteLine("Erro: por favor digite números.");
}
Console.Write("Digite uma tecla para encerrar.");
Console.ReadLine();