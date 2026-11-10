/*   
    OPERAÇÕES MATEMÁTICAS BÁSICAS Escreva um programa que solicite ao
    usuário dois números e realize as quatro operações matemáticas
    básicas: adição, subtração, multiplicação e divisão. Ao final,
    apresente os resultados de cada operação.
*/

float numero1 = 0.00f;
float numero2 = 0.00f;

Console.WriteLine("Digite o PRIMEIRO numero: ");
numero1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o SEGUNDO numero: ");
numero2 = float.Parse(Console.ReadLine());

float soma = numero1 + numero2;
float subtracao= numero1 - numero2;
float multiplicacao = numero1 * numero2;
float divisao = numero1 / numero2;

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtração: " + subtracao);
Console.WriteLine("Multiplicação: " + multiplicacao);
Console.WriteLine("Divisão: " + divisao);

