int opcoes;

do
{
    Console.WriteLine("Escolha uma das opções a seguir:");
    Console.WriteLine("1.Exibir uma mensagem ;");
    Console.WriteLine("2.Soma;");
    Console.WriteLine("3.Sair;");

    while (!int.TryParse(Console.ReadLine(), out opcoes))
    {
        Console.WriteLine("Insira um numero válido:");
        Console.Write("Escolha uma opção: ");
    }

    switch (opcoes)
    {
        case 1:
            Console.WriteLine("Bom dia, já bebeu água hoje?");
            break;

        case 2:
            Console.WriteLine("Digite um número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double soma = num1 + num2;
            Console.WriteLine($"A soma é {soma}");
            break;
        case 3:
            Console.WriteLine("Programa encerrando. Tchauzinho..");
            break;
        default:
            Console.WriteLine("Opção Inválida, digite as opçãoes 1, 2 ou 3.");
            break;
    }
    Console.WriteLine();
}
while (opcoes != 3);

Console.Write("Digite uma tecla para encerrar.");
Console.ReadKey();