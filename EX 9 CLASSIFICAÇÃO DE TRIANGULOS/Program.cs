/* 
 CLASSIFICAÇÃO DE TRIÂNGULOS Escreva um programa que solicite ao
    usuário os valores dos três lados de um triângulo. O programa deverá
    verificar se os valores informados podem formar um triângulo válido
    e, caso sejam válidos, classificá-lo de acordo com os seguintes
    critérios:

-   Equilátero: possui os três lados iguais.
-   Isósceles: possui dois lados iguais.
-   Escaleno: possui os três lados diferentes.
 */

float lado1 = 0.00f;
float lado2 = 0.00f;
float lado3 = 0.00f;

Console.WriteLine("Escreva o valor do LADO 1:");
lado1 = float.Parse(Console.ReadLine());
Console.WriteLine("Escreva o valor do LADO 2:");
lado2 = float.Parse(Console.ReadLine());
Console.WriteLine("Escreva o valor do LADO 3:");
lado3 = float.Parse(Console.ReadLine());

if ((lado1 + lado2 > lado3) && (lado2 + lado3 > lado1) && (lado1 + lado3 > lado2))
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
    {
        Console.WriteLine("Triângulo Isósceles");
    }
    else
    {
        Console.WriteLine("Triângulo Escaleno");
    }
}
else
{
    Console.WriteLine("Não é um triângulo");
}   