double n1, n2, n3;
double soma;
double media;

Console.Write("Informe sua primeira nota: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe sua segunda nota: ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe sua terceira nota: ");
n3 = Convert.ToDouble(Console.ReadLine());

soma = n1 + n2  + n3;
media = soma / 3;

Console.WriteLine($"A média das suas notas é {media}.");
