﻿using SuperCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtracao
{
    public class Subtrair : IOperacao
    {
        public string Divisao()
        {
            throw new NotImplementedException();
        }

        public void Multiplicacao()
        {
            
        }


        public string Subtracao()
        {
            Console.WriteLine("Digite o Primeiro Número da Operação:");
            int n1 = TesteNumero.RecebeNumero();

            Console.WriteLine("Digite o Segundo Número da Operação:");
            int n2 = TesteNumero.RecebeNumero();

            Console.Clear();

            return $"{n1} - {n2} = {n1 - n2}";
        }

        public string Soma()
        {
            throw new NotImplementedException();
        }
    }
}