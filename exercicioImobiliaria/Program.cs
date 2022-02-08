using System;

namespace exercicioImobiliaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 1 -------------------------------------------------------------------------
               
            double valorB, valorH, result;

            Console.Write("Digite o valor da base do terreno em (cm): ");

            valorB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do terreno em (cm): ");

            valorH = Convert.ToDouble(Console.ReadLine());

            result = valorB * valorH;

            Console.WriteLine(result);
            
            Console.WriteLine("Pressione qualquer tecla para sair!");

            Console.ReadLine();
            ------------------------------------------------------------------------- */



            /* Exercicio 2 -------------------------------------------------------------------------
             //Requisitos:
             //Cada pãozinho custa R$ 0,12 e broa custa R$ 1,50 // valores fixos
            
            int pao, broa;
            double  precPao,precBroa;
            double calculo, deposito, totDeposito; //declaração de variaveis

            precPao = 0.12;
            precBroa = 1.50; //definição de valores fixos

            Console.Write("Digite quantos pães foram vendidos hoje: ");
            pao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Digite quantas broas foram vendidas hoje: ");
            broa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            calculo = (pao * precPao) + (broa * precBroa);  //calculo do 

            Console.WriteLine("O total das vendas de hoje foi de? " + calculo);
            Console.WriteLine("");

            deposito = calculo * 0.10;
            totDeposito = calculo - deposito;

            Console.WriteLine("Você terá que depositar em sua Conta poupança: " + totDeposito.ToString("F2"));
            Console.WriteLine(" ");
            Console.WriteLine("Pressione qualquer tecla para sair!");
            Console.ReadLine();
            -------------------------------------------------------------------------*/



            /* Exercicio 3 -------------------------------------------------------------------------
               // /*Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir 
               //quantos dias de vidaela possui. Considere sempre anos completos, e que um 
               // ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja
               // um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS
             
             

            string nome;
            int idade;
            double calculo;

            Console.Write("Digite seu Primeiro nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            calculo = idade * 365;

            Console.WriteLine(nome + ", você já viveu: " + calculo + " dias");
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para sair!");
            Console.ReadLine();
           
            -------------------------------------------------------------------------/*



            /* Exercicio 4 -------------------------------------------------------------------------
             //Alguns países medem temperaturas em graus Celsius, e outros em graus
             //Fahrenheit. Faça umalgoritmo para ler uma temperatura Celsius e imprimi-Ia em
             //Fahrenheit (pesquise como fazer estetipo de conversão).

             
            double tempCelsius, conversao;

            Console.Write("Digite a temperatura em graus Celsius (C°): ");
            tempCelsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");
            
            conversao = (tempCelsius * 1.8) + 32;

            Console.WriteLine("A Temperatura em Fahreinheit é: " + conversao);
            Console.WriteLine(" ");
            Console.WriteLine("Pressione qualquer tecla para sair!");
            Console.ReadLine();
            -------------------------------------------------------------------------*/



            /* Exercicio 5 -------------------------------------------------------------------------
            // Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
             //Após o aumento,desconte 8% de impostos. Imprima o salário inicial, o salário
             //com o aumento e o salário final.
            */
            double salario, salarioAumento, imposto, salarioFinal;

            salarioAumento = 0.15;
            imposto = 0.08;
                
            Console.Write("Digite o seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Seu salario inicial é de: " + salario);
            Console.WriteLine("");

            salarioAumento = salario * salarioAumento;
            salario = salarioAumento + salario;
            Console.WriteLine("Seu salario com aumento é de: " + salario);
            Console.WriteLine("");

            imposto =  imposto * salario ;
            salario = salario - imposto;
            Console.WriteLine("Seu salário final com os descontos de impostos é de:  " + salario);

            Console.ReadLine();
        }
    }
}
