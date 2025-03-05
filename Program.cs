using System;

namespace Respostas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalcularDescontoINSS();
            DetalharData();
        }

        public static void CalcularDescontoINSS()
        {
            Console.WriteLine("");
            Console.WriteLine("Digite o valor salarial:");
            double salario = double.Parse(Console.ReadLine());
            double desconto = 0;
            double salarioDesconto = 0;

            if (salario <= 1212)
            {
                desconto = salario * 0.075;
                salarioDesconto = salario - desconto;
            }
            else if (salario > 1212.01 && salario <= 2427.35)
            {
                desconto = salario * 0.09;
                salarioDesconto = salario - desconto;
            }
            else if (salario > 2427.35 && salario <= 3641.03)
            {
                desconto = salario * 0.12;
                salarioDesconto = salario - desconto;
            }
            else
            {
                desconto = salario * 0.14;
                salarioDesconto = salario - desconto;
            }

            Console.WriteLine("");
            string frase = string.Format("O valor do desconto é {0:C2}. O salário descontando o INSS é {1:C2}", desconto, salarioDesconto);
            Console.WriteLine(frase);
            Console.WriteLine("");
        }

        public static void DetalharData()
        {
            Console.WriteLine("");
            Console.WriteLine("Digite a data:");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                string fraseDetalhada = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yyyy} - {0:HH:mm:ss}", data);
                Console.WriteLine(fraseDetalhada);
            }
            else
            {
                string fraseSimples = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yyyy}", data);
                Console.WriteLine(fraseSimples);
            }
        }
    }
}

