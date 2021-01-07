using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BitBank
{
    static class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 1234;
            contaDaGabriela.numeroCC = 123456789;
            contaDaGabriela.saldo = 100.50;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine(contaDaGabriela.agencia);
            Console.WriteLine(contaDaGabriela.numeroCC);
            Console.WriteLine(contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine(contaDaGabriela.saldo);


            Console.ReadLine();
        }
    }
}
