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

            Console.ReadLine();
        }
    }
}
