/* CÁLCULO DE AUMENTO SALARIAL Escreva um programa que solicite o
    salário atual de um funcionário e calcule o aumento salarial de
    acordo com as seguintes regras:

-   Salário de até R$ 2.000,00: aumento de 15%.
-   Salário entre R$ 2.000,01 e R$ 4.000,00: aumento de 10%.
-   Salário acima de R$ 4.000,00: aumento de 5%. Ao final, apresente o
    percentual de aumento, o valor do reajuste e o novo salário.*/

float salario = 0.00f;
float aumento = 0.00f;

Console.WriteLine("Digite seu salário: ");
salario = float.Parse(Console.ReadLine());

if (salario <= 2000.00) 
{
    aumento = salario * 0.15f;
    salario *= 1.15f;
    Console.WriteLine("A % de aumento do seu salário foi de : 15%");
    Console.WriteLine("O valor do aumento do seu salário foi de : " + aumento );
    Console.WriteLine("Com o aumento seu salário irá ficar: " + salario);
}
else if (salario >= 2000.01 && salario <= 4000.00)
{
    aumento = salario * 0.10f;
    salario *= 1.10f;
    Console.WriteLine("O % de aumento do seu salário foi de : 10%");
    Console.WriteLine("O valor do aumento do seu salário foi de : " + aumento);
    Console.WriteLine("Com o aumento seu salário irá ficar: " + salario);
}
else 
{
    aumento = salario * 0.05f;
    salario *= 1.05f;
    Console.WriteLine("O % de aumento do seu salário foi de : 5%");
    Console.WriteLine("O valor do aumento do seu salário foi de : " + aumento);
    Console.WriteLine("Com o aumento seu salário irá ficar: " + salario);
}

