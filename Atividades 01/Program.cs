/*1.Faça um programa que leia três números, verifique (usando if e else) 
/ * e mostre o maior e o menor deles; (Não utilize estrutura de repetição)*/

using System;

int n1, n2, n3, maiorNumero = 0, menorNumero = 0;

Console.WriteLine("Digite o primeiro número : ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o Segundo número : ");
n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro  número : ");
n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    maiorNumero = n1;
}
if (n2 > n1 && n2 > n3)
{
    maiorNumero = n2;
}
if (n3 > n1 && n3 > n2)
{
    maiorNumero = n3;
}
if (n1 < n2 && n1 < n3)
{
    menorNumero = n1;
}
if (n2 < n1 && n2 < n3)
{
    menorNumero = n2;
}
if (n3 < n1 && n3 < n2)
{
    menorNumero = n3;
}
Console.WriteLine("O maior número é : " + maiorNumero + " e o menor é " + menorNumero);
