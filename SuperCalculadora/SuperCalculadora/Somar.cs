using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora
{
    public class Somar : IOperacao
    {
        public void Divisao()
        {   
        }

        public void Multiplicacao()
        {
        }

        public int Soma()
        {
            int resultado = 0;
            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite outro número para somar com {n1}");
            int n2 = int.Parse(Console.ReadLine());
            resultado = n1 + n2;
            return resultado;
        }

        public string Subtracao()
        {
            throw new NotImplementedException();
        }
    }
}
