//2. Faça um programa que leia três números e mostre-os em ordem decrescente
// (Não utilize estrutura de repetição)

using System.Reflection.Metadata.Ecma335;

int n1, n2, n3, decrescente = 0, outronumero = 0, menorNumero = 0;

Console.WriteLine("Digite o Primero número : ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o Segundo número : ");
n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o Terceiro número : ");
n3 = Convert.ToInt32(Console.ReadLine());


if (n1 > n2 && n1 > n3)

{
    decrescente = n1;
}
else if (n2 > n1 && n2 > n3)
{
    decrescente = n2;
}
else if (n3 > n1 && n3 > n2)
{
    decrescente = n3;
}
outronumero = menorNumero + 1;

if (n1 < n2 && n1 < n3)
{
    menorNumero = n1;


}
else if (n2 < n1 && n2 < n3)
{
    menorNumero = n2;

}
else if (n3 < n1 && n3 < n2)
{
    menorNumero = n3;


}

Console.WriteLine(+decrescente + " ," + outronumero + "," + menorNumero + ",");