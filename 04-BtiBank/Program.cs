using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BtiBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.profissao = "dev";
            gabriela.cpf = "123456789012";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;

            Console.WriteLine($"Titular: {conta.titular.nome}");

            Console.ReadLine();
        }
    }
}
