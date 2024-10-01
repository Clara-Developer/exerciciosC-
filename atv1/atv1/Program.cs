string nome1;
string nome2;
string areapg;

Console.Write("Qual é seu primeiro nome?");
nome1 = Console.ReadLine();

Console.Write("Qual é seu sobrenome?");
nome2 = Console.ReadLine();

Console.Write("qual das áreas de programação você mais se interessa?");
areapg = Console.ReadLine();

Console.WriteLine($"meu nome completo é {nome1} {nome2} e área de programação que você mais se interessa é {areapg}");