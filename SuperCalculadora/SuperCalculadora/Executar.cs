﻿using Subtracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora
{
    public interface IOperacao
    {
        int Soma();
        int Subtracao();
        void Divisao();
        void Multiplicacao();
    }

    public class Executar
    {
        public static void Executor()
        {
            var entrada = string.Empty;
            int opcao = 0;

            StringBuilder menu = new StringBuilder();
            menu.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-= Super Calculadora =-=-=-=-=-=-=-=-=-=-=-=-=");
            menu.AppendLine("Escolha a Sua Operação:");
            menu.AppendLine("1 - Adição");
            menu.AppendLine("2 - Subtração");
            menu.AppendLine("3 - Divisão");
            menu.AppendLine("4 - Multiplicação");
            menu.AppendLine("5 - Sair");

            do
            {
                Console.Clear();
                Console.WriteLine(menu);
                entrada = Console.ReadLine();

                if (int.TryParse(entrada, out opcao))
                {
                    Console.Clear();
                    switch (opcao)
                    {
                        case 1:
                            var soma = new Somar();
                            Console.WriteLine("Opção Adição!");
                            Console.WriteLine($"Resultado = {soma.Soma()}");
                            break;
                        case 2:
                            var resultadoSubtracao = new Subtrair();
                            Console.WriteLine($"Resultado = {resultadoSubtracao.Subtracao()}");
                            break;
                        case 3:
                            Console.WriteLine("Opção Divisão!");
                            Console.WriteLine($"Resultado = ");
                            break;
                        case 4:
                            Console.WriteLine("Opção Multíplicação!");
                            Console.WriteLine($"Resultado = ");
                            break;
                        case 5:
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    if (opcao != 5)
                    {
                        Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu prinicpal.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu prinicpal.");
                    Console.ReadKey();
                }
            } while (opcao != 5);
        }
    }
}
