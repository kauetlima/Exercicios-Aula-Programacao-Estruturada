/*  
    NÚMERO PAR OU ÍMPAR Escreva um programa que solicite ao usuário um
    número inteiro e verifique se ele é par ou ímpar. Ao final, exiba
    uma mensagem informando o resultado.
*/

int numero = 0;

Console.WriteLine("Digite um numero INTEIRO: ");
numero = int.Parse (Console.ReadLine ());

if (numero % 2 == 0)
{
    Console.WriteLine("O numero digitado é PAR");
}
else
    Console.WriteLine("O Numero Digitado é IMPAR");
 