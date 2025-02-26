using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Operacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                
            Console.Write("Digite seu nome: ");
            String nome = Console.ReadLine();

            Console.Write("Digite um número: ");
            double num1 = double.Parse(Console.ReadLine());


            Console.Write("Digite o numero dois: ");
            double num2 = double.Parse(Console.ReadLine());

            double soma = num1 + num2;
            double sub = num1 - num2;
            double multiplicacao = num1 * num2;
            double divisao = num1 / num2;


            Console.WriteLine($"\n Resultado das operações: {soma}");
            Console.WriteLine($"\n Resultado das operações: {sub}");
            Console.WriteLine($"\n Resultado das operações: {multiplicacao}");
            Console.WriteLine($"\n Resultado das operações: {divisao}");


            Console.Write("Digite qualquer coisa para sair...");

                Console.WriteLine("\n Comparação entre números");
                Console.WriteLine($"Os números são iguais? {num1 == num2 }");

                Console.WriteLine($"Os números são diferentes!!! {num1 != num2}");

                Console.WriteLine($"O primeiro numero é maior que o segundo? {num1 > num2}");

                //Operadores lógicos 

                bool ambosPositivos = num1 > 0 && num2 > 0;
                bool nenhumNegativo = !(num1 < 0 || num2 < 0);
                Console.WriteLine($"Ambos positivos: {ambosPositivos} \n " +
                    $"Nenhum negativo: {nenhumNegativo}");

                if (Directory.Exists("D:/pedro/docs")) {
                    Console.WriteLine("Pasta existe");
                }
                else {
                    Console.WriteLine("Pasta não existe");
                    Directory.CreateDirectory("D:/pedro/docs");
                }






            }
            catch (Exception ex) {
            Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
