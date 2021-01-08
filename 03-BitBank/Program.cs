using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BitBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            contaDoBruno.Sacar(50);

            Console.WriteLine($"Titular: {contaDoBruno.titular} saldo: {contaDoBruno.saldo}");

            contaDoBruno.Depositar(500);

            Console.WriteLine($"Titular: {contaDoBruno.titular} saldo: {contaDoBruno.saldo}");

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine($"Titular: {contaDoBruno.titular} saldo: {contaDoBruno.saldo}, Saldo da cont da Gabriela {contaDaGabriela.saldo}");

            Console.ReadLine();
        }
    }
}
