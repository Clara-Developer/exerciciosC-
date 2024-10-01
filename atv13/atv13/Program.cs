
int numeroSecreto = 7;
int palpite;
bool acertou = false;

do
{
    Console.Write("Digite um número (entre 1 e 10): ");
    palpite = int.Parse(Console.ReadLine());

    if (palpite == numeroSecreto)
    {
        Console.WriteLine(" Você adivinhou o número secreto.");
        acertou = true;
    }
    else
    {
        Console.WriteLine("Tente novamente.");
    }
} while (!acertou);

Console.Write("Digite uma tecla para encerrar.");
Console.ReadKey();
