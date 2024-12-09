using Divisao;
using Subtracao;
using System.Text;

namespace SuperCalculadora
{
    public interface IOperacao
    {
        string Soma();
        string Subtracao();
        string Divisao();
        string Multiplicacao();
    }

    class TesteNumero
    {
        public static int RecebeNumero()
        {
            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }

            return numero;
        }
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
                            Console.WriteLine(soma.Soma());
                            break;
                        case 2:
                            var resultadoSubtracao = new Subtrair();
                            Console.WriteLine(resultadoSubtracao.Subtracao());
                            break;
                        case 3:
                            var dividir = new Dividir();
                            Console.WriteLine(dividir.Divisao());
                            break;
                        case 4:
                            var multiplicar = new Multiplicar();
                            Console.WriteLine(multiplicar.Multiplicacao());
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
                        Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu principal.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu principal.");
                    Console.ReadKey();
                }
            } while (opcao != 5);
        }
    }
}
