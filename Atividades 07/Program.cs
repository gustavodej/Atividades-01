/*7.Faça um programa para calcular n! (Fatorial de n), sendo que o valor inteiro de n é fornecido pelo usuário. Sabe-se que: 

N! = 1 * 2 * 3 * … (n – 1) *n
0! = 1, por definição;
*/

int num = 0, farotial = 1, cont;

Console.WriteLine("Digite um número para o cálculo do fatorial :");
num = int.Parse(Console.ReadLine());

if (num < 0)
{
    Console.WriteLine("Número inválido .Apenas números > Zero .");
}

else if ((num == 0) || (num == 1))
{
    Console.WriteLine("Fatorial de {0} é 1.", num);
}
else
{
    for (cont = num; cont >= 1; cont--)
    {
        farotial *= cont;
    }
    Console.WriteLine(" Fatorial de {0} é {1} ", num, farotial);