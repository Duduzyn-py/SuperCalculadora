using SuperCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtracao
{
    public class Subtrair : IOperacao
    {
        public void Divisao()
        {
            
        }

        public void Multiplicacao()
        {
            
        }

        public int Soma()
        {
            return 0;
        }

        public int Subtracao()
        {
            Console.WriteLine("Digite o Primeiro Número da Operação:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número da Operação:");
            int n2 = int.Parse(Console.ReadLine());

            return n1 - n2;
        }
    }
}