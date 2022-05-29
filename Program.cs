double Graus = 0.0;
double Fahrenheit = 0.0;

Console.WriteLine("Escreva a temperatura em graus para a conversao em Fahrenheit");
Graus = Convert.ToInt32(Console.ReadLine());

Fahrenheit = (9 * Graus + 160) / 5;

Console.WriteLine($"{Graus}° em Fahrenheit é igual a: {Fahrenheit}");