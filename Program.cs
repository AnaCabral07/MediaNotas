// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

double nota1, nota2, nota3, nota4, media;
string resultado;


Console.WriteLine("-- Média --\n");
Console.WriteLine("Digite as suas notas abaixo.");

Console.Write("Digite sua primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua segunda nota:  ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua quarta nota:   ");
nota4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

if (nota1 < 0 || nota1 > 10
 || nota2 < 0 || nota2 > 10 
 || nota3 < 0 || nota3 > 10
 || nota4 < 0 || nota4 > 10)
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
}
else 
{
    media = (nota1 + nota2 + nota3 + nota4) / 4;

    if (media < 5)
    {
        resultado = "REPROVADO!!!";
    }
    else if (media > 6)
    {
        resultado = "APROVADO!!!";
    }
    else
    {
        resultado = "Em RECUPERAÇÃO!!!";
    }

    Console.WriteLine($"Você ficou com média {media}. Resultado: {resultado}");
}





    
