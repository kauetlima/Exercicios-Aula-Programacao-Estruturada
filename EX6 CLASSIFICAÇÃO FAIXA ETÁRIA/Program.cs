/*  
    CLASSIFICAÇÃO POR FAIXA ETÁRIA Escreva um programa que solicite a
    idade de uma pessoa e a classifique de acordo com as seguintes
    faixas etárias:

-   Criança: até 12 anos.
-   Adolescente: de 13 a 17 anos.
-   Adulto: de 18 a 59 anos.
-   Idoso: 60 anos ou mais.
*/

int idade = 0;

Console.WriteLine("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade <= 12)
{
    Console.WriteLine("Você é Criança");
}
else if (idade >=13 && idade<=17)
{
    Console.WriteLine("Você é Adolescente");

}
else if (idade>= 18 && idade<=59)
{
    Console.WriteLine("Você é Adulto");
}
else
    Console.WriteLine("Você é Idoso");





