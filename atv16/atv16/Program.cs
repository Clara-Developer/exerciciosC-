Console.Write("Informe um valor positivo: ");

if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
{
    long fatorial = 1;

    for (int i = 1 ; i <= numero; i++)
    {
        fatorial *= i;
    }

    Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
}
else
{
    Console.WriteLine("Número inválido");
}
Console.Write("Digite uma tecla para encerrar.");
Console.ReadKey();