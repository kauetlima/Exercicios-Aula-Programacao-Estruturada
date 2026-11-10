/*  
    IDENTIFICAÇÃO DE ANO BISSEXTO Escreva um programa que solicite ao
    usuário um ano e verifique se ele é ou foi bissexto. Ao final, exiba
    uma mensagem informando o resultado.
*/

int ano = 0;

Console.WriteLine("Digite o ano que deseja saber se é ou foi bissexto: ");
ano = int.Parse(Console.ReadLine());

if ((ano % 4 ==0) && (ano % 100 != 0) || (ano % 400 == 0))
{
    Console.WriteLine("Ano Bissexto");
}
else
{
    Console.WriteLine("Ano não Bissexto");
}
