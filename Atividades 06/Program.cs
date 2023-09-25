/*6.Faça um programa que receba o valor de um carro
e mostre uma tabela com os seguintes dados:
preço final, quantidade de parcelas e valor da parcela. Considere o seguinte: 
O preço final para compra à vista tem um desconto de 20%;
A quantidades de parcelas pode ser: 6, 12, 18, 24, 30, 36, 42, 48, 54 e 60. 
Os percentuais de acréscimo seguem a tabela a seguir.  


Quantidade de Parcelas => Percentual de acréscimo sobre o preço final
6 => 3%
12 => 6%
18 => 9%
24 => 12%
30 => 15%
36 => 18%
42 => 21%
48 => 24%
54 => 27%
60 => 30%
*/

int precoCarro = 0, quantidadeParcela = 0, precoFinal, PrecoTotal;
decimal valorParcela = 0;
string formaPagamento = "A";

Console.WriteLine("Digite o valor do carro :");
precoCarro = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(" A forma de pagamento é a vista ou parcelada ? A =  A vista e P = Parcelado :");
formaPagamento = Console.ReadLine();


if (formaPagamento == "A")
{
    Console.WriteLine("O valor do seu Carro é : " + precoCarro +
         "\nPor ser um  pagamento á vista,seu carro terá um desconto de 20 % do valor  e ficará :" + (precoCarro * 20 / 100) + " R$ mais barato");
}
if (formaPagamento == "P")
{
    Console.WriteLine("A quantidades de parcelas só  podem ser (6,12,18,24,30,36,42,48,54 ou 60");
    Console.WriteLine("Digite a quantidade de parcelas.");
    quantidadeParcela = Convert.ToInt32(Console.ReadLine());
}


switch (quantidadeParcela)
{
    case 6:

        PrecoTotal = (precoCarro * 3 / 100 + precoCarro);
        valorParcela = (PrecoTotal / 6);
        Console.WriteLine("O Parcelamento em 6 vezes tem um acrescimo de 3 % do valor à vista que é de :\n"
            + precoCarro + " R$ e passará  para um  total de " + PrecoTotal + " R$, as parcelas ficaram 6 X de " + valorParcela + " R$ cada .");
        break;
    case 12:

        PrecoTotal = (precoCarro * 6 / 100 + precoCarro);
        valorParcela = (PrecoTotal / 12);
        Console.WriteLine("O Parcelamento em 12 vezes tem um acrescimo de 6 % do valor à vista que é de :\n"
            + precoCarro + " R$ e passará  para um  total de " + PrecoTotal + " R$, as parcelas ficaram 12 X de " + valorParcela + " R$ cada .");
        break;

    case 18:

        PrecoTotal = (precoCarro * 9 / 100 + precoCarro);
        valorParcela = (PrecoTotal / 18);
        Console.WriteLine("O Parcelamento em 18 vezes tem um acrescimo de 9 % do valor à vista que é de :\n"
            + precoCarro + " R$ e passará  para um  total de " + PrecoTotal + " R$, as parcelas ficaram 18 X de " + valorParcela + " R$ cada .");
        break;
    case 24:

        PrecoTotal = (precoCarro * 12 / 100 + precoCarro);
        valorParcela = (PrecoTotal / 24);
        Console.WriteLine("O Parcelamento em 24 vezes tem um acrescimo de 12 % do valor à vista que é de :\n"
            + precoCarro + " R$ e passará  para um  total de " + PrecoTotal + " R$, as parcelas ficaram 24 X de " + valorParcela + " R$ cada .");
        break;

    case 30:

        PrecoTotal = (precoCarro * 15 / 100 + precoCarro);
        valorParcela = (PrecoTotal / 30);
        Console.WriteLine("O Parcelamento em 30 vezes tem um acrescimo de 15 % do valor à vista que é de :\n"
            + precoCarro + " R$ e passará  para um  total de " + PrecoTotal + " R$, as parcelas ficaram 30 X de " + valorParcela + " R$ cada .");
        break;

    case 36:

        PrecoTotal = (precoCarro * 18 / 100 + precoCarro);
        valorParcela = (PrecoTotal / 36);
        Console.WriteLine("O Parcelamento em 36 vezes tem um acrescimo de 18 % do valor à vista que é de :\n"
            + precoCarro + " R$ e passará  para um  total de " + PrecoTotal + " R$, as parcelas ficaram 36 X de " + valorParcela + " R$ cada .");
        break;

    case 42:

        PrecoTotal = (precoCarro * 21 / 100 + precoCarro);
        valorParcela = (PrecoTotal / 42);
        Console.WriteLine("O Parcelamento em 42 vezes tem um acrescimo de 21 % do valor à vista que é de :\n"
            + precoCarro + " R$ e passará  para um  total de " + PrecoTotal + " R$, as parcelas ficaram 42 X de " + valorParcela + " R$ cada .");
        break;

    case 48:

        PrecoTotal = (precoCarro * 24 / 100 + precoCarro);
        valorParcela = (PrecoTotal / 48);
        Console.WriteLine("O Parcelamento em 48 vezes tem um acrescimo de 24 % do valor à vista que é de :\n"
            + precoCarro + " R$ e passará  para um  total de " + PrecoTotal + " R$, as parcelas ficaram 48 X de " + valorParcela + " R$ cada .");
        break;

    case 54:

        PrecoTotal = (precoCarro * 27 / 100 + precoCarro);
        valorParcela = (PrecoTotal / 54);
        Console.WriteLine("O Parcelamento em 6 vezes tem um acrescimo de 27 % do valor à vista que é de :\n"
            + precoCarro + " R$ e passará  para um  total de " + PrecoTotal + " R$, as parcelas ficaram 54 X de " + valorParcela + " R$ cada .");
        break;

    case 60:

        PrecoTotal = (precoCarro * 30 / 100 + precoCarro);
        valorParcela = (PrecoTotal / 60);
        Console.WriteLine("O Parcelamento em 60 vezes tem um acrescimo de 30 % do valor à vista que é de :\n"
            + precoCarro + " R$ e passará  para um  total de " + PrecoTotal + " R$, as parcelas ficaram 60 X de " + valorParcela + " R$ cada .");
        break;

    default:
        Console.WriteLine("Essa opção de parcelamento não está disponivel !");

        break;
}