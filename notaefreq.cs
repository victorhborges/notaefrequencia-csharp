System.Console.WriteLine("Insira seu nome:");
var nome = System.Console.ReadLine();

System.Console.WriteLine("Insira sua Nota 1:");
var N1 = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("Insira sua Nota 2:");
var N2 = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("Insira sua Nota 3:");
var N3 = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("Insira seu percentual de frequência:");
double freq = Convert.ToInt32(System.Console.ReadLine());

var media = (N1 + N2 + N3) / 3;
var mediaarred = Math.Round(media, 2);

System.Console.WriteLine("===SISTEMA DE AVALIAÇÃO===");
System.Console.WriteLine($"Nome do estudante: {nome}");
System.Console.WriteLine($"Nota 1: {N1}");
System.Console.WriteLine($"Nota 2: {N2}");
System.Console.WriteLine($"Nota 3: {N3}");
System.Console.WriteLine($"Frequência: {freq}%");
System.Console.WriteLine("---RESULTADO---");
System.Console.WriteLine($"Média: {mediaarred}");

if (media >= 7)
{
    System.Console.WriteLine("Status da nota: Aprovado por nota");
}

else if (media < 5)
{
    System.Console.WriteLine("Status da nota: Reprovado por nota");
}

else
{
    System.Console.WriteLine("Status da nota: Recuperação");
}

if (freq < 75)
{ System.Console.WriteLine("Status da frequencia: Reprovado por falta"); }

else
{
    System.Console.WriteLine("Status da frequencia: Frequencia adequada");
}

if ((media >= 7) && (freq >= 75))
{
    System.Console.WriteLine("RESULTADO FINAL: APROVADO");

}

else if ((media >= 5) && (media < 7) && (freq > 75))
{
    System.Console.WriteLine("RESULTADO FINAL: RECUPERAÇÃO");
}

else
{
    System.Console.WriteLine("RESULTADO FINAL: REPROVADO");
}
