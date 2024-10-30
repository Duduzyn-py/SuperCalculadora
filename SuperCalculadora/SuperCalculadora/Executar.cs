using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora
{
    public interface IOperacao
    {
        void Adicao();
        void Subtracao();
        void Divisao();
        void Multiplicacao();
    }

    public class Somar
    {
        public int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
    }

    public class Executar
    {
        public static void Executor()
        {
            var soma = new Somar();
            Console.WriteLine(soma.Soma(20, 30));

            //var subtrair = new Subtrair();
            //Console.WriteLine(subtrair.Subtracao(100, 30));
        }
    }
}
