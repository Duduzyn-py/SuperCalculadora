﻿using SuperCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisao
{
    public class Dividir : IOperacao
    {
        public string Divisao()
        {
            Console.WriteLine("Digite o Primeiro Número da Operação:");
            int n1 = TesteNumero.RecebeNumero();

            Console.WriteLine("Digite o Segundo Número da Operação:");
            int n2 = TesteNumero.RecebeNumero();

            Console.Clear();

            if (n2 == 0)
            {
                return "Erro: Divisão por zero não é permitida.";
            }

            return $"{n1} / {n2} = {n1 / (double)n2}";
        }

        public void Multiplicacao()
        {

        }

        public string Soma()
        {
            throw new NotImplementedException();
        }

        public string Subtracao()
        {
            throw new NotImplementedException();

        }

    }
}
