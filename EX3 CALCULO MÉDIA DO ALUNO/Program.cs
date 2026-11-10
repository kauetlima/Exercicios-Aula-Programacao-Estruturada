/*  
    CÁLCULO DA MÉDIA E SITUAÇÃO DO ALUNO Escreva um programa que
    solicite quatro notas de um aluno, calcule a média aritmética e
    informe sua situação de acordo com os seguintes critérios:

-   Aprovado: média maior ou igual a 7,0.
-   Recuperação: média entre 5,1 e 6,9.
-   Reprovado: média menor ou igual a 5,0.
*/

float nota1 = 0.00f;
float nota2 = 0.00f;
float nota3 = 0.00f;
float nota4 = 0.00f;
float media = 0.00f;

Console.WriteLine("Digite a NOTA 1: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a NOTA 2: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a NOTA 3: ");
nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a NOTA 4: ");
nota4 = float.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;
Console.WriteLine(media);

if (media >= 7.00)
{
    Console.WriteLine("ALUNO APROVADO");
}
else if (media >= 5.1 && media <= 6.9)
{
    Console.WriteLine("ALUNO FICOU DE RECUPERAÇÃO");

}
else
    Console.WriteLine("REPROVADO");




