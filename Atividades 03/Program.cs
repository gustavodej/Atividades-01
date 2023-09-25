//3.Faça um programa para o cálculo de uma folha de pagamento, sabendo que os descontos são do imposto de Renda,
//que depende do salário bruto (conforme tabela abaixo) e 3% para o Sindicato e que o FGTS corresponde a 11% do salário bruto,
//mas não é descontado (é a empresa que deposita.) 
//O salário líquido corresponde ao salário bruto menos os descontos O programa deverá pedir ao usuário o valor da sua hora e
//a quantidade de horas trabalhadas no mês. 
//a. Desconto do IR;
//b.Salário Bruto ate R$900,00 (inclusive) – Isento;
//c.Salário Bruto de R$ 1500, 00 (inclusive) – desconto de 5%;
//d.Salario bruto até R$ 2500,00 (Inclusive) – desconto de 10%;
//e.Salário bruto acima de 2500 – Desconto de 20%. 
//Imprima na tela as informações, dispostas conforme o exemplo abaixo, no exemplo valor da hora é 5 e a quantidade de horas é 220.  

//Salário bruto (5 * 220)           : R$   1100,00 
//( – ) IR(5 %)                             : R$     75,00 
//( – ) Sindicato(3 % )                : R$     33,00
//FGTS ( 11%)                            : R$     121,00
//Total de descontos                : R$     165,00 
//Salário Líquido                       : R$     1.012,00

using System.Collections.Generic;

decimal salario, desconto = 0, valorHora, ir = 0, horasTrabalhadas, sindicato = 0, fgts = 0, salarioLiquido, totalDesconto = 0;

Console.WriteLine("Digite a  o valor  das  horas trabalhadas: ");
horasTrabalhadas = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a quantidade de horas trabalhadas :");
valorHora = Convert.ToDecimal(Console.ReadLine());
salario = horasTrabalhadas * valorHora;



if (salario <= 900)
{
    Console.WriteLine("Seu salário é :" + salario + " R$ você esta isento de descontos");
}
else
{


    if (salario == 1500)
    {
        ir = (salario * 5 / 100);
        sindicato = (salario * 3 / 100);
        fgts = (salario * 11 / 100);
        desconto = (ir + sindicato + fgts);
        totalDesconto = salario - desconto;
    }
    else if (salario <= 2500)
    {
        ir = (salario * 10 / 100);
        sindicato = (salario * 3 / 100);
        fgts = (salario * 11 / 100);
        desconto = (ir + sindicato + fgts);
        totalDesconto = salario - desconto;
    }
    else if (salario > 2500)
    {
        ir = (salario * 20 / 100);
        sindicato = (salario * 3 / 100);
        fgts = (salario * 11 / 100);
        desconto = (ir + sindicato + fgts);
        totalDesconto = salario - desconto;
    }
    Console.WriteLine("Seu salário que é : " + salario + " R$ ,\nTem um desconto do IR de  "
    + ir + " R$ \nO seu  FGTS  " + fgts + " R$  \nMais o desconto do sindicato " + sindicato + " R$ \nO total de descontos é  de " + desconto + " R$" +
    " \nSeu salário liquido é de " + totalDesconto + " R$");
}
