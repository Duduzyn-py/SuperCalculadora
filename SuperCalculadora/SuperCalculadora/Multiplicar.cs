using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora
{
    public class Multiplicar : IOperacao
    {

        public int Multiplicacao()
        {
            int resultado = 0;
            int n1;
            int n2;

            Console.WriteLine("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            
            if (n1  == 0)
            {
             Console.WriteLine("Multiplição por zero resulta em zero");
            }
            
            if (n2 == 0) 
            { 
             Console.WriteLine("Multiplição por zero resulta em zero");
            }
            
            resultado = n1 * n2;
            return resultado;
        }
    }
}
