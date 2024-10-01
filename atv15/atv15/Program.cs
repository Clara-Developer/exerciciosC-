Console.Write("digite um numero positivo: ");
int numero = int.Parse(Console.ReadLine());
int numero2 = numero * 10;


Console.WriteLine($"\nO resultado da tabuada do {numero} é:");
for (int i = 0; i <= numero2; i += numero)
{
    Console.WriteLine(i);
}

Console.WriteLine("Digite uma tecla para sair! ");
Console.ReadKey();