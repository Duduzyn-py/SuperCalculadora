﻿namespace SuperCalculadora
{
     public class Multiplicar : IOperacao
    {
        public string Multiplicacao()
        {
            Console.WriteLine("Digite o Primeiro Número da Operação:");
            int n1 = TesteNumero.RecebeNumero();

            Console.WriteLine("Digite o Segundo Número da Operação:");
            int n2 = TesteNumero.RecebeNumero();

            Console.Clear();

            return $"{n1} x {n2} = {n1 * n2}";
        }
        public string Divisao()
        {
            throw new NotImplementedException();
        }
        public string Subtracao()
        {
            throw new NotImplementedException();
        }
        public string Soma()
        {
            throw new NotImplementedException();
        }
    }
}
