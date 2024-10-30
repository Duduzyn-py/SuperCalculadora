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
        void Subtracao();
        void Divisao();
        void Multiplicacao();
    }

    public class Executar
    {
        public static void Executor()
        {
            //var soma = new Somar();
            //Console.WriteLine(soma.Soma());

            //var subtrair = new Subtrair();
            //Console.WriteLine(subtrair.Subtracao(100, 30));
        }
    }
}
