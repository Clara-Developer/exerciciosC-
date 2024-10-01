double salario;
double porcentagem;
double conta;
double salariof;

Console.Write("Informe seu salário: ");
salario = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o percentual do aumento: ");
porcentagem = Convert.ToDouble(Console.ReadLine());

conta = salario * porcentagem / 100;

salariof = conta + salario;


Console.WriteLine($"O seu salário de R${salario} com o aumento de {porcentagem} fica R${salariof}");
