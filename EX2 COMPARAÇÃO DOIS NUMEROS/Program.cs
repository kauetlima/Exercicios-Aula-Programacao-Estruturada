/*  
    COMPARAÇÃO ENTRE DOIS NÚMEROS Escreva um programa que solicite ao
    usuário dois números decimais e compare seus valores. O programa
    deverá informar se o primeiro número é maior, menor ou igual ao
    segundo.
*/

float numero1 = 0.00f;
float numero2 = 0.00f;

Console.WriteLine("Digite o PRIMEIRO numero DECIMAL(EX: 2,00): ");
numero1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o SEGUNDO numero DECIMAL (EX: 2,00): ");
numero2 = float.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("O PRIMEIRO numero é maior que o SEGUNDO numero");
}
else if (numero1 < numero2)
{
    Console.WriteLine("O PRIMEIRO numero é menor que o SEGUNDO numero");

}
else
    Console.WriteLine("Os DOIS numeros tem o mesmo valor");




