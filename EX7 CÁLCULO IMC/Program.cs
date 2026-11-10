/*  CÁLCULO DO IMC (ÍNDICE DE MASSA CORPORAL) Escreva um programa que
    solicite ao usuário seu peso em quilogramas (kg) e sua altura em
    centímetros (cm). Em seguida, calcule o Índice de Massa Corporal
    (IMC) e apresente a classificação correspondente ao resultado
    obtido.
*/


using System.Xml.Serialization;

float peso = 0.00f;
float altura = 0.00f;
int idade = 0;
char sexo;
char gestante;
float imc;

Console.WriteLine("Digite seu sexo (M = Masculino F = Feminino)");
sexo = char.Parse(Console.ReadLine());
Console.WriteLine("Digite sua idade:");
idade = int.Parse(Console.ReadLine());
Console.WriteLine("Você é gestante ? ( S = Sim N = Não)");
gestante = char.Parse(Console.ReadLine());
Console.WriteLine("Digite seu PESO em KG: ");
peso = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua ALTURA em CM: ");
altura = float.Parse(Console.ReadLine());

imc = peso / ((altura / 100) * (altura / 100));

if (sexo == 'F' && idade>= 20 && gestante == 'S')
{   
     if(imc <  18.5 )
    {
        Console.WriteLine("Baixo Peso");
    }
    else if (imc >= 18.5 && imc <= 24.9) 
    {
        Console.WriteLine("Peso Adequado");
    }
    else if (imc >= 25 && imc <= 29.9) 
    {
        Console.WriteLine("Sobrepeso");
    }
    else if (imc >= 30)
    {
        Console.WriteLine("Obesidade");
    }

}
else if (idade >= 19 && idade<=59) 
{
    if (imc < 18.5)
    {
        Console.WriteLine("Baixo Peso");
    }
    else if (imc >= 18.5 && imc <= 24.9)
    {
        Console.WriteLine("Peso Adequado");
    }
    else if (imc >= 25 && imc <= 29.9)
    {
        Console.WriteLine("Sobrepeso");
    }
    else if (imc >= 30.00 && imc<=34.9)
    {
        Console.WriteLine("Obesidade Grau 1");
    }
    else if (imc >= 35.00 && imc <= 39.9)
    {
        Console.WriteLine("Obesidade Grau 2");
    }
    else if (imc >= 40.00)
    {
        Console.WriteLine("Obesidade Grau 3");
    }
}
else if (idade >= 60)
{
    if (imc <= 22.00)
    {
        Console.WriteLine("Baixo Peso");
    }
    else if (imc > 22.00 && imc <= 27.00)
    {
        Console.WriteLine("Peso Adequado");
    }
    else if (imc >= 27.01)
    {
        Console.WriteLine("Sobrepeso");
    }
}
else
{
    Console.WriteLine("Esse programa só funciona para pessoas com mais de 19 anos.");
}


