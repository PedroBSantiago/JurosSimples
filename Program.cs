double TaxaDeJuros,Capital,Tempo;

double JurosSimples; 
double Montante;

Console.Write("Capital [c] (R$).......:");
Capital = Convert.ToInt32(Console.ReadLine());

Console.Write("Taxa de juros [i] (%)..:");
TaxaDeJuros = Convert.ToInt32(Console.ReadLine());


Console.Write("Tempo [t] (meses)......:");
Tempo = Convert.ToInt32(Console.ReadLine());

JurosSimples = Capital * TaxaDeJuros * Tempo;

Montante = JurosSimples + Capital;

Console.WriteLine($"Juros (R$).....:{Capital} *  {TaxaDeJuros} * {Tempo} = {JurosSimples}");

Console.WriteLine($"Montante (R$)..:{Capital} +  {JurosSimples} = {Montante}");
