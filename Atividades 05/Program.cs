/*5. Escreva um programa que lê o tamanho do lado de um quadrado
e imprime um quadrado daquele tamanho com asteriscos.
Seu programa deve usar laços de repetição e funcionar
para quadrados com lados de todos os tamanhos entre 1 e 20.
Por exemplo, para lado igual a 5:
*****
*****
*****
*****
*****
*/

int lado;

Console.WriteLine("Digite o tamanho do lado do quadrado (entre 1 e 20 ) :");
lado = Convert.ToInt32(Console.ReadLine());

if (lado < 1 || lado > 20)
{
    Console.WriteLine("Tamanho inválido.O tamanho deve esta entre ( 1 e 20 )");
    return;
}
for (int i = 0; i < lado; i++)
{
    for (int j = 0; j < lado; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

