double celsius;
double fahrenheit;

Console.Write("Informe a temperatura em celsius: ");
celsius = Convert.ToDouble(Console.ReadLine());

fahrenheit = celsius * (9) / 5 + 32;

Console.WriteLine($"Sua temperatura em Fahrenheit é: {fahrenheit}.");