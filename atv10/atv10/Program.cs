
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe um um número de 1 a 12 correspondente ao mês que deseja. ");
        int mes = int.Parse(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine("Você escolheu o mês de jaineiro cuja a estação é verão");
                break;

            case 2:
                Console.WriteLine("Você escolheu o mês de fevereiro cuja a estação é verão");
                break;

            case 3:
                Console.WriteLine("Você escolheu o mês de março cuja a estação é outono");
                break;

            case 4:
                Console.WriteLine("Você escolheu o mês de abril cuja a estação é outono");
                break;

            case 5:
                Console.WriteLine("Você escolheu o mês de maio cuja a estação é outono");
                break;

            case 6:
                Console.WriteLine("Você escolheu o mês de junho cuja a estação é inverno");
                break;

            case 7:
                Console.WriteLine("Você escolheu o mês de julho cuja a estação é inverno");
                break;

            case 8:
                Console.WriteLine("Você escolheu o mês de agosto cuja a estação é inverno");
                break;

            case 9:
                Console.WriteLine("Você escolheu o mês de setembro cuja a estação é primavera");
                break;

            case 10:
                Console.WriteLine("Você escolheu o mês de outubro cuja a estação é primavera");
                break;

            case 11:
                Console.WriteLine("Você escolheu o mês de novembro cuja a estação é primavera");
                break;

            case 12:
                Console.WriteLine("Você escolheu o mês de dezembro cuja a estação é verão");
                break;

            default:
                Console.WriteLine("O numero escolhido não é permitido");
                break;
        }
        Console.WriteLine("Digite uma tecla pra encerrar");
        Console.ReadKey();
    }
}