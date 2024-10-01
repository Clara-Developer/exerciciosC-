double valorR;
double multiplicação;
double PI;

PI = 3.14;
Console.Write("Informe o valor do raio: ");
valorR = Convert.ToInt16(Console.ReadLine());

multiplicação = PI * valorR * valorR;
Console.WriteLine($"A multiplicação dos valores é: {multiplicação}");
