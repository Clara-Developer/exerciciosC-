int v1, v2;
int soma;
int subtração;
int multiplicação;
double divisão;

Console.Write("Informe seu primeiro número: ");
v1 = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe seu segundo número: ");
v2 = Convert.ToInt16(Console.ReadLine());

soma = v1 + v2;
Console.WriteLine($"A soma dos valores é: {soma}");

subtração = v1 - v2;    
Console.WriteLine($"A subtração dos valores é: {subtração}");

multiplicação = v1 * v2;
Console.WriteLine($"A multiplicação dos valores é: {soma}");

divisão = v1 / v2;
Console.WriteLine($"A divisão dos valores é: {divisão}");
