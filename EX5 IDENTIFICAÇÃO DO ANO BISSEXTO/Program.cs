/*  
    IDENTIFICAÇÃO DE ANO BISSEXTO Escreva um programa que solicite ao
    usuário um ano e verifique se ele é ou foi bissexto. Ao final, exiba
    uma mensagem informando o resultado.
*/

int ano = 0;

Console.WriteLine("Digite o ano que deseja saber se é ou foi bissexto: ");
ano = int.Parse(Console.ReadLine());

if ((ano % 4 == 0 || ano % 100 == 0) && ano < 2026)
{
    Console.WriteLine("Esse foi um ano Bissexto");
}
else if ((ano % 4 == 0 || ano % 100 == 0)  && ano > 2026)
{
    Console.WriteLine("Esse irá ser um ano Bissexto");
}
else
    Console.WriteLine("Esse ano não é Bissexto");